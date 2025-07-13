using EShift.Business.Interface;
using EShift.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift.Forms
{
    public partial class AssignTransportUnitForm : Form
    {
        private int _selectedJobId;
        private IJobService _jobService;
        private ITransportUnitService _transportUnitService; // Use this directly now
        private ILorryService _lorryService; // Still needed for updating individual lorry status
        private IDriverService _driverService; // Still needed for updating individual driver status
        private IAssistantService _assistantService; // Still needed for updating individual assistant status
        private IContainerService _containerService; // Still needed for updating individual container status
        private INotificationService _notificationService;
        private ICustomerService _customerService;

        private Job _currentJob;
        public AssignTransportUnitForm(int jobId,
            IJobService jobService,
            ITransportUnitService transportUnitService, // Now directly passing TransportUnitService
            ILorryService lorryService, // Need these to update IsAvailable status
            IDriverService driverService,
            IAssistantService assistantService,
            IContainerService containerService,
            INotificationService notificationService,
            ICustomerService customerService)
        {
            InitializeComponent();
            _selectedJobId = jobId;
            _jobService = jobService;
            _transportUnitService = transportUnitService; // Assign the new service
            _lorryService = lorryService;
            _driverService = driverService;
            _assistantService = assistantService;
            _containerService = containerService;
            _notificationService = notificationService;
            _customerService = customerService;

            this.Load += AssignTransportUnitForm_Load;
        }

        private void AssignTransportUnitForm_Load(object sender, EventArgs e)
        {
            LoadJobAndCustomerDetails();
            LoadAvailableTransportUnits();
            InitializeInputFields();
        }

        private void LoadJobAndCustomerDetails()
        {
            try
            {
                _currentJob = _jobService.GetJobById(_selectedJobId);
                if (_currentJob != null)
                {
                    // Populate Job Details UI (Scheduled dates, Location, Status)
                    lblJobNumber.Text = _currentJob.JobNumber;
                    lblPickupLocation.Text = _currentJob.PickupLocation;
                    lblDeliveryLocation.Text = _currentJob.DeliveryLocation;
                    lblRequestedDate.Text = _currentJob.RequestedDate.ToShortDateString();
                    lblJobStatus.Text = _currentJob.JobStatus;

                    // Set Scheduled dates for display (not for updating here, just showing initial plan)
                    //dtpScheduledPickup.Value = _currentJob.ScheduledPickupDate ?? DateTime.Now;
                    //dtpScheduledDelivery.Value = _currentJob.ScheduledDeliveryDate ?? DateTime.Now.AddDays(1);


                    // Pre-fill Actual Pickup/Delivery Dates if they exist
                    if (_currentJob.ActualPickupDate.HasValue)
                    {
                        dtpActualPickupDate.Value = _currentJob.ActualPickupDate.Value;
                        dtpActualPickupDate.CustomFormat = "MM/dd/yyyy"; // Ensure format is visible
                    }
                    else
                    {
                        dtpActualPickupDate.CustomFormat = " "; // Hide initial date if null
                    }

                    if (_currentJob.ActualDeliveryDate.HasValue)
                    {
                        dtpActualDeliveryDate.Value = _currentJob.ActualDeliveryDate.Value;
                        dtpActualDeliveryDate.CustomFormat = "MM/dd/yyyy"; // Ensure format is visible
                    }
                    else
                    {
                        dtpActualDeliveryDate.CustomFormat = " "; // Hide initial date if null
                    }


                    // Fetch and Populate Customer Details for context
                    if (_currentJob.CustomerID.HasValue)
                    {
                        Customer customer = _customerService.GetCustomerById(_currentJob.CustomerID.Value);
                        if (customer != null)
                        {
                            lblCustomerNumber.Text = customer.CustomerNumber;
                            lblCustomerFirstName.Text = customer.FirstName;
                            lblCustomerLastName.Text = customer.LastName;
                            lblCustomerPhoneNumber.Text = customer.PhoneNumber;
                            lblCustomerEmail.Text = customer.Email;
                        }
                        else
                        {
                            lblCustomerFirstName.Text = "Customer Not Found";
                            ClearCustomerLabels();
                        }
                    }
                    else
                    {
                        lblCustomerFirstName.Text = "No Customer Assigned";
                        ClearCustomerLabels();
                    }

                    // Pre-fill Remarks, QuotedPrice, FinalPrice if they exist
                    txtRemarks.Text = _currentJob.Remarks ?? string.Empty;
                    txtQuotedPrice.Text = _currentJob.QuotedPrice?.ToString("F2") ?? string.Empty;
                    txtFinalPrice.Text = _currentJob.FinalPrice?.ToString("F2") ?? string.Empty;

                    // If a TransportUnit is already assigned, select it in the ComboBox
                    if (_currentJob.TransportUnitID.HasValue)
                    {
                        // Check if the assigned TransportUnit is in the list of available units.
                        // If it's not (e.g., because its components are no longer available),
                        // you might want to add it temporarily or handle it differently.
                        // For now, we'll just try to select it.
                        cmbTransportUnits.SelectedValue = _currentJob.TransportUnitID.Value;
                        // Optionally, disable selection if already assigned and form is for review
                        // cmbTransportUnits.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("Selected job not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading job and customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ClearCustomerLabels()
        {
            lblCustomerNumber.Text = "";
            lblCustomerFirstName.Text = "";
            lblCustomerLastName.Text = "";
            lblCustomerPhoneNumber.Text = "";
            lblCustomerEmail.Text = "";
        }

        private void InitializeInputFields()
        {
            // Set DateTimePicker custom format for optional dates (if empty, shows " ")
            // These should also be set in the designer for initial state
            dtpActualPickupDate.Format = DateTimePickerFormat.Custom;
            dtpActualPickupDate.CustomFormat = " ";
            dtpActualDeliveryDate.Format = DateTimePickerFormat.Custom;
            dtpActualDeliveryDate.CustomFormat = " ";

            // Hook up event handlers programmatically if not done in designer
            dtpActualPickupDate.ValueChanged += dtpActualPickupDate_ValueChanged;
            dtpActualDeliveryDate.ValueChanged += dtpActualDeliveryDate_ValueChanged;
            dtpActualPickupDate.KeyDown += dtpActualPickupDate_KeyDown;
            dtpActualDeliveryDate.KeyDown += dtpActualDeliveryDate_KeyDown;
        }


        private void LoadAvailableTransportUnits()
        {
            try
            {
                // Get all transport units that are IsOperational and whose components
                // are currently IsAvailable.
                // Note: This logic assumes you have GetAll* methods on your services.
                // If not, you might need a GetAvailable* method on TransportUnitService
                // that handles this complex join/filtering at the service layer.
                List<TransportUnit> availableTransportUnits = _transportUnitService.GetAllTransportUnits()
                    .Where(tu => tu.IsOperational &&
                                 _lorryService.GetLorryById(tu.LorryID)?.IsAvailable == true &&
                                 _driverService.GetDriverById(tu.DriverID)?.IsAvailable == true &&
                                 (tu.AssistantID == null || _assistantService.GetAssistantById(tu.AssistantID.Value)?.IsAvailable == true) &&
                                 (tu.ContainerID == null || _containerService.GetContainerById(tu.ContainerID.Value)?.IsAvailable == true)
                    )
                    .ToList();

                // If a TransportUnit is already assigned to this job, and it's not in the available list,
                // you might want to add it temporarily so it can be selected/viewed.
                if (_currentJob != null && _currentJob.TransportUnitID.HasValue)
                {
                    TransportUnit currentAssignedTU = _transportUnitService.GetTransportUnitById(_currentJob.TransportUnitID.Value);
                    if (currentAssignedTU != null && !availableTransportUnits.Any(tu => tu.TransportUnitID == currentAssignedTU.TransportUnitID))
                    {
                        availableTransportUnits.Insert(0, currentAssignedTU); // Add to top for visibility
                    }
                }

                cmbTransportUnits.DataSource = availableTransportUnits;
                cmbTransportUnits.DisplayMember = "UnitName"; // Or "LorryRegistrationNumber" if you prefer
                cmbTransportUnits.ValueMember = "TransportUnitID";
                cmbTransportUnits.SelectedIndex = -1; // No default selection
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading available transport units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper for Actual DatePickers to clear/set value
        private void dtpActualPickupDate_ValueChanged(object sender, EventArgs e)
        {
            // Only change format if value is not MinDate (which signifies "cleared")
            if (dtpActualPickupDate.Value.Date == dtpActualPickupDate.MinDate.Date)
            {
                dtpActualPickupDate.CustomFormat = " ";
            }
            else
            {
                dtpActualPickupDate.CustomFormat = "MM/dd/yyyy"; // Or your preferred format
            }
        }

        private void dtpActualDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpActualDeliveryDate.Value.Date == dtpActualDeliveryDate.MinDate.Date)
            {
                dtpActualDeliveryDate.CustomFormat = " ";
            }
            else
            {
                dtpActualDeliveryDate.CustomFormat = "MM/dd/yyyy"; // Or your preferred format
            }
        }

        // Logic to allow clearing DateTimePicker by pressing backspace/delete
        private void dtpActualPickupDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtpActualPickupDate.Value = dtpActualPickupDate.MinDate; // Set to MinDate to signify null/clear
                dtpActualPickupDate.CustomFormat = " "; // Hide date
                e.Handled = true; // Prevent further processing of key
            }
        }

        private void dtpActualDeliveryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                dtpActualDeliveryDate.Value = dtpActualDeliveryDate.MinDate; // Set to MinDate to signify null/clear
                dtpActualDeliveryDate.CustomFormat = " "; // Hide date
                e.Handled = true; // Prevent further processing of key
            }
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (_currentJob == null)
            {
                MessageBox.Show("No job loaded for assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbTransportUnits.SelectedValue == null || (int)cmbTransportUnits.SelectedValue == -1)
            {
                MessageBox.Show("Please select a Transport Unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedTransportUnitId = (int)cmbTransportUnits.SelectedValue;
            TransportUnit assignedTransportUnit = _transportUnitService.GetTransportUnitById(selectedTransportUnitId);

            if (assignedTransportUnit == null)
            {
                MessageBox.Show("Selected Transport Unit not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update Job with assigned TransportUnit and other fields
            _currentJob.TransportUnitID = selectedTransportUnitId;
            // IMPORTANT: If your Job model has these foreign keys, uncomment and assign them:
            //_currentJob.LorryID = assignedTransportUnit.LorryID;
            //_currentJob.DriverID = assignedTransportUnit.DriverID;
            //_currentJob.AssistantID = assignedTransportUnit.AssistantID;
            //_currentJob.ContainerID = assignedTransportUnit.ContainerID;

            // Retrieve Scheduled dates from the form (if they are intended to be editable here)
            // If they are just for display, remove these lines.
            //_currentJob.ScheduledPickupDate = dtpScheduledPickup.Value;
            //_currentJob.ScheduledDeliveryDate = dtpScheduledDelivery.Value;

            // Get prices and remarks from inputs
            _currentJob.Remarks = txtRemarks.Text.Trim();
            if (string.IsNullOrWhiteSpace(_currentJob.Remarks)) _currentJob.Remarks = null;

            decimal quotedPrice;
            if (decimal.TryParse(txtQuotedPrice.Text, out quotedPrice))
            {
                _currentJob.QuotedPrice = quotedPrice;
            }
            else
            {
                _currentJob.QuotedPrice = null; // Or show validation error
            }

            decimal finalPrice;
            if (decimal.TryParse(txtFinalPrice.Text, out finalPrice))
            {
                _currentJob.FinalPrice = finalPrice;
            }
            else
            {
                _currentJob.FinalPrice = null; // Or show validation error
            }

            // Set Actual Pickup/Delivery Dates (nullable if not set/cleared)
            // THIS IS WHERE THE FIX IS FOR ACTUAL DATES
            _currentJob.ActualPickupDate = (dtpActualPickupDate.CustomFormat == " " || dtpActualPickupDate.Value == dtpActualPickupDate.MinDate) ? (DateTime?)null : dtpActualPickupDate.Value;
            _currentJob.ActualDeliveryDate = (dtpActualDeliveryDate.CustomFormat == " " || dtpActualDeliveryDate.Value == dtpActualDeliveryDate.MinDate) ? (DateTime?)null : dtpActualDeliveryDate.Value;


            // Set Admin Assigned Date and update Job Status
            _currentJob.AdminAssignedDate = DateTime.Now;
            _currentJob.JobStatus = "Assigned"; // Update job status

            try
            {
                // 1. Update the Job record
                bool jobUpdateSuccess = _jobService.UpdateJob(_currentJob);

                if (jobUpdateSuccess)
                {
                    // 2. Update IsAvailable status of the *components* of the assigned TransportUnit to false
                    // Lorry
                    Lorry lorry = _lorryService.GetLorryById(assignedTransportUnit.LorryID);
                    if (lorry != null)
                    {
                        lorry.IsAvailable = false;
                        _lorryService.UpdateLorry(lorry);
                    }

                    // Driver
                    Driver driver = _driverService.GetDriverById(assignedTransportUnit.DriverID);
                    if (driver != null)
                    {
                        driver.IsAvailable = false;
                        _driverService.UpdateDriver(driver);
                    }

                    // Assistant (if assigned)
                    if (assignedTransportUnit.AssistantID.HasValue)
                    {
                        Assistant assistant = _assistantService.GetAssistantById(assignedTransportUnit.AssistantID.Value);
                        if (assistant != null)
                        {
                            assistant.IsAvailable = false;
                            _assistantService.UpdateAssistant(assistant);
                        }
                    }

                    // Container (if assigned)
                    if (assignedTransportUnit.ContainerID.HasValue)
                    {
                        Models.Container container = _containerService.GetContainerById(assignedTransportUnit.ContainerID.Value);
                        if (container != null)
                        {
                            container.IsAvailable = false;
                            _containerService.UpdateContainer(container);
                        }
                    }

                    // 3. Send Notification to Customer about assignment
                    if (_currentJob.CustomerID.HasValue)
                    {
                        Customer customer = _customerService.GetCustomerById(_currentJob.CustomerID.Value);
                        if (customer != null && customer.UserID.HasValue)
                        {
                            _notificationService.AddNotification(new Notification
                            {
                                UserID = customer.UserID.Value,
                                MessageType = "Job_Assigned",
                                MessageContent = $"Your job '{_currentJob.JobNumber}' has been assigned a transport unit for pickup on {_currentJob.ScheduledPickupDate?.ToShortDateString()}. Quoted Price: {_currentJob.QuotedPrice?.ToString("C")}.",
                                RelatedEntityID = _currentJob.JobID,
                                RelatedEntityType = "Job"
                            });
                        }
                    }

                    MessageBox.Show("Job assigned successfully, resources updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update job details after assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during assignment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
