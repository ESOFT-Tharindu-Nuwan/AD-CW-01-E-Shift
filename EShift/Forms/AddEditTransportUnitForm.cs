using EShift.Business.Interface;
using EShift.Business.Service;
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
    public partial class AddEditTransportUnitForm : Form
    {
        private ITransportUnitService _transportUnitService;
        private ILorryService _lorryService; // To populate Lorry ComboBox
        private IDriverService _driverService; // To populate Driver ComboBox
        //private IAssistantService _assistantService; // To populate Assistant ComboBox
        //private IContainerService _containerService; // To populate Container ComboBox

        private int? _transportUnitId; // Nullable int: null for Add, ID for Edit
        private TransportUnit _currentTransportUnit;

        public AddEditTransportUnitForm()
        {
            InitializeComponent();
            InitializeServices();
            _transportUnitId = null; // Indicate Add mode
            this.Text = "Add New Transport Unit";
            lblFormTitle.Text = "Add New Transport Unit";
            btnSubmit.Text = "Add Unit";
            chkIsOperational.Checked = true; // Default to operational
            LoadComboBoxes();
        }

        public AddEditTransportUnitForm(int transportUnitId)
        {
            InitializeComponent();
            InitializeServices();
            _transportUnitId = transportUnitId; // Indicate Edit mode
            this.Text = "Edit Transport Unit";
            lblFormTitle.Text = "Edit Transport Unit";
            btnSubmit.Text = "Update Unit";
            LoadComboBoxes();
            LoadTransportUnitData(); // Load existing data for editing
        }
        private void InitializeServices()
        {
            _transportUnitService = new TransportUnitService();
            _lorryService = new LorryService();
            _driverService = new DriverService();
            //_assistantService = new AssistantService();
            //_containerService = new ContainerService();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Get input from UI
            string unitName = txtUnitName.Text.Trim();
            int? lorryId = cmbLorry.SelectedValue as int?;
            int? driverId = cmbDriver.SelectedValue as int?;
            int? assistantId = cmbAssistant.SelectedValue as int?;
            int? containerId = cmbContainer.SelectedValue as int?;
            bool isOperational = chkIsOperational.Checked;

            // 2. Client-side Validation
            if (string.IsNullOrEmpty(unitName))
            {
                MessageBox.Show("Unit Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lorryId == null || lorryId <= 0)
            {
                MessageBox.Show("Please select a Lorry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (driverId == null || driverId <= 0)
            {
                MessageBox.Show("Please select a Driver.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Handle optional Assistant and Container selections
            int? finalAssistantId = (assistantId == -1) ? (int?)null : assistantId;
            int? finalContainerId = (containerId == -1) ? (int?)null : containerId;

            // 3. Create/Update TransportUnit object
            TransportUnit unitToSave = _currentTransportUnit ?? new TransportUnit();

            unitToSave.UnitName = unitName;
            unitToSave.LorryID = lorryId.Value;
            unitToSave.DriverID = driverId.Value;
            unitToSave.AssistantID = finalAssistantId;
            unitToSave.ContainerID = finalContainerId;
            unitToSave.IsOperational = isOperational;

            try
            {
                bool success;
                if (_transportUnitId.HasValue) // Edit mode
                {
                    unitToSave.TransportUnitID = _transportUnitId.Value; // Ensure ID is set for update
                    success = _transportUnitService.UpdateTransportUnit(unitToSave);
                }
                else // Add mode
                {
                    success = _transportUnitService.AddTransportUnit(unitToSave);
                }

                if (success)
                {
                    MessageBox.Show("Transport Unit saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save transport unit. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadTransportUnitData()
        {
            try
            {
                _currentTransportUnit = _transportUnitService.GetTransportUnitById(_transportUnitId.Value);
                if (_currentTransportUnit != null)
                {
                    txtUnitName.Text = _currentTransportUnit.UnitName;
                    cmbLorry.SelectedValue = _currentTransportUnit.LorryID;
                    cmbDriver.SelectedValue = _currentTransportUnit.DriverID;
                    cmbAssistant.SelectedValue = _currentTransportUnit.AssistantID ?? -1; // Handle nullable
                    cmbContainer.SelectedValue = _currentTransportUnit.ContainerID ?? -1; // Handle nullable
                    chkIsOperational.Checked = _currentTransportUnit.IsOperational;
                }
                else
                {
                    MessageBox.Show("Transport Unit not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport unit data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Lorries
                List<Lorry> lorries = _lorryService.GetAllLorries();
                cmbLorry.DataSource = lorries;
                cmbLorry.DisplayMember = "RegistrationNumber"; // Display registration number
                cmbLorry.ValueMember = "LorryID";
                cmbLorry.SelectedIndex = -1; // No selection by default

                // Drivers
                List<Driver> drivers = _driverService.GetAllDrivers();
                cmbDriver.DataSource = drivers;
                cmbDriver.DisplayMember = "FirstName"; // Display first name, consider full name
                cmbDriver.ValueMember = "DriverID";
                cmbDriver.SelectedIndex = -1;

                // Assistants (Optional, can be null)
                //List<Assistant> assistants = _assistantService.GetAllAssistants();
                //assistants.Insert(0, new Assistant { AssistantID = -1, FirstName = "-- Select None --" }); // Option for null
                //cmbAssistant.DataSource = assistants;
                //cmbAssistant.DisplayMember = "FirstName";
                //cmbAssistant.ValueMember = "AssistantID";
                //cmbAssistant.SelectedValue = -1;

                // Containers (Optional, can be null)
                //List<Models.Container> containers = _containerService.GetAllContainers();
                //containers.Insert(0, new Models.Container { ContainerID = -1, ContainerNumber = "-- Select None --" }); // Option for null
                //cmbContainer.DataSource = containers;
                //cmbContainer.DisplayMember = "ContainerNumber";
                //cmbContainer.ValueMember = "ContainerID";
                //cmbContainer.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdown data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
