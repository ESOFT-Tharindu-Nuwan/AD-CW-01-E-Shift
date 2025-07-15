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
    public partial class AdminDashboardForm : Form
    {
        private readonly IJobService _jobService;
        private readonly ILorryService _lorryService;
        private readonly IDriverService _driverService;
        private readonly ITransportUnitService _transportUnitService;
        private readonly IAssistantService _assistantService;
        private readonly IContainerService _containerService;

        private readonly IUserService _userService;
        private readonly INotificationService _notificationService;
        private readonly ICustomerService _customerService;
        private readonly IEmailService _emailService;

        private readonly IReportService _reportService;

        private int _currentAdminUserId;
        private List<Customer> _allCustomersCache;
        private List<Job> _allJobsCache;

        public AdminDashboardForm(int adminUserId, IEmailService emailService)
        {
            InitializeComponent();

            _currentAdminUserId = adminUserId;

            _jobService = new JobService();
            _lorryService = new LorryService();
            _driverService = new DriverService();
            _transportUnitService = new TransportUnitService();
            _assistantService = new AssistantService();
            _containerService = new ContainerService();
            _userService = new UserService();
            _notificationService = new NotificationService();
            _customerService = new CustomerService();
            _reportService = new ReportService(_jobService, _customerService);

            LoadDashboardOverview();
            LoadAllJobs();
            LoadAllLorries();
            LoadAllDrivers();
            LoadAllTransportUnits();
            LoadAllAssistants();
            LoadAllContainers();
            LoadAdminNotifications();
            LoadAllCustomers();
            LoadAllUsers();
            InitializeSearchFilters();
            this.MaximizeBox = false;
        }

        private void LoadAllUsers()
        {
            try
            {
                List<User> allUsers = _userService.GetAllUsers();
                dgvUsers.DataSource = allUsers;
                dgvUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSearchFilters()
        {
            cmbSearchCustomersBy.Items.AddRange(new string[] { "Customer Number", "First Name", "Last Name", "Email", "Phone Number" });
            cmbSearchCustomersBy.SelectedIndex = 0;

            cmbSearchJobsBy.Items.AddRange(new string[] { "Job Number", "Pickup Location", "Delivery Location", "Job Status" });
            cmbSearchJobsBy.SelectedIndex = 0;
        }

        private void LoadAllCustomers()
        {
            try
            {
                _allCustomersCache = _customerService.GetAllCustomers();
                ApplyCustomerFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardOverview()
        {
            try
            {
                lblTotalActiveJobs.Text = _jobService.GetTotalActiveJobsCount().ToString();
                lblPendingRequests.Text = _jobService.GetPendingJobRequestsCount().ToString();
                lblAvailableLorries.Text = new LorryService().GetAvailableLorriesCount().ToString();
                lblAvailableDrivers.Text = new DriverService().GetAvailableDriversCount().ToString();
                lblTotalCustomers.Text = new CustomerService().GetTotalCustomersCount().ToString();

                User loggedUser = _userService.GetByUserId(_currentAdminUserId);
                lblLoggedUsername.Text = loggedUser.Username;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard overview: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllJobs()
        {
            try
            {
                _allJobsCache = _jobService.GetAllJobs();
                ApplyJobFilter();
                dgvJobs.AutoGenerateColumns = false;
                dgvJobs.Columns.Clear();

                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobID", HeaderText = "Job ID", ReadOnly = true });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobNumber", HeaderText = "Job No." });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerID", HeaderText = "Customer ID" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RequestedDate", HeaderText = "Requested Date" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ScheduledPickupDate", HeaderText = "Scheduled Pickup" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ActualPickupDate", HeaderText = "Actual Pickup" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ActualDeliveryDate", HeaderText = "Actual Delivery" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PickupLocation", HeaderText = "Pickup Location" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeliveryLocation", HeaderText = "Delivery Location" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JobStatus", HeaderText = "Status" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TransportUnitID", HeaderText = "Unit ID" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "QuotedPrice", HeaderText = "Quoted Price" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FinalPrice", HeaderText = "Final Price" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Remarks", HeaderText = "Remarks" });
                dgvJobs.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AdminAssignedDate", HeaderText = "Assigned Date" });

                dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllLorries()
        {
            try
            {
                List<Lorry> allLorries = _lorryService.GetAllLorries();
                dgvLorries.DataSource = allLorries;
                dgvLorries.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lorries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLorry_Click(object sender, EventArgs e)
        {
            AddEditLorryForm addForm = new AddEditLorryForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllLorries(); // Refresh the list after adding
                LoadDashboardOverview(); // Update counts
            }
        }

        private void btnDeleteLorry_Click(object sender, EventArgs e)
        {
            if (dgvLorries.SelectedRows.Count > 0)
            {
                int selectedLorryId = (int)dgvLorries.SelectedRows[0].Cells["LorryID"].Value;
                string registrationNumber = dgvLorries.SelectedRows[0].Cells["RegistrationNumber"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete lorry '{registrationNumber}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (_lorryService.DeleteLorry(selectedLorryId))
                        {
                            MessageBox.Show("Lorry deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllLorries(); // Refresh the list
                            LoadDashboardOverview(); // Update counts
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete lorry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException ex) // Catch if lorry is in use
                    {
                        MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a lorry to delete.", "No Lorry Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditLorry_Click(object sender, EventArgs e)
        {
            if (dgvLorries.SelectedRows.Count > 0)
            {
                int selectedLorryId = (int)dgvLorries.SelectedRows[0].Cells["LorryID"].Value;
                AddEditLorryForm editForm = new AddEditLorryForm(selectedLorryId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllLorries(); // Refresh the list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select a lorry to edit.", "No Lorry Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadAllDrivers()
        {
            try
            {
                List<Driver> allDrivers = _driverService.GetAllDrivers();
                dgvDrivers.DataSource = allDrivers;
                dgvDrivers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drivers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddEditDriverForm addForm = new AddEditDriverForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllDrivers(); // Refresh the list after adding
                LoadDashboardOverview(); // Update counts
            }
        }

        private void btnEditDriver_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                int selectedDriverId = (int)dgvDrivers.SelectedRows[0].Cells["DriverID"].Value;
                AddEditDriverForm editForm = new AddEditDriverForm(selectedDriverId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllDrivers(); // Refresh the list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to edit.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                int selectedDriverId = (int)dgvDrivers.SelectedRows[0].Cells["DriverID"].Value;
                string driverName = $"{dgvDrivers.SelectedRows[0].Cells["FirstName"].Value} {dgvDrivers.SelectedRows[0].Cells["LastName"].Value}";

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete driver '{driverName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (_driverService.DeleteDriver(selectedDriverId))
                        {
                            MessageBox.Show("Driver deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllDrivers(); // Refresh the list
                            LoadDashboardOverview(); // Update counts
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete driver.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException ex) // Catch if driver is in use
                    {
                        MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to delete.", "No Driver Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllTransportUnits()
        {
            try
            {
                List<TransportUnit> allUnits = _transportUnitService.GetAllTransportUnits();
                dgvTransportUnits.DataSource = allUnits;
                dgvTransportUnits.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport units: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTransportUnit_Click(object sender, EventArgs e)
        {
            AddEditTransportUnitForm addForm = new AddEditTransportUnitForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllTransportUnits(); // Refresh the list after adding
                LoadDashboardOverview(); // Update counts
            }
        }

        private void btnEditTransportUnit_Click(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count > 0)
            {
                int selectedUnitId = (int)dgvTransportUnits.SelectedRows[0].Cells["TransportUnitID"].Value;
                AddEditTransportUnitForm editForm = new AddEditTransportUnitForm(selectedUnitId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllTransportUnits(); // Refresh the list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select a transport unit to edit.", "No Unit Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteTransportUnit_Click(object sender, EventArgs e)
        {
            if (dgvTransportUnits.SelectedRows.Count > 0)
            {
                int selectedUnitId = (int)dgvTransportUnits.SelectedRows[0].Cells["TransportUnitID"].Value;
                string unitName = dgvTransportUnits.SelectedRows[0].Cells["UnitName"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete transport unit '{unitName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (_transportUnitService.DeleteTransportUnit(selectedUnitId))
                        {
                            MessageBox.Show("Transport Unit deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllTransportUnits(); // Refresh the list
                            LoadDashboardOverview(); // Update counts
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete transport unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a transport unit to delete.", "No Unit Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllAssistants()
        {
            try
            {
                List<Assistant> allAssistants = _assistantService.GetAllAssistants();
                dgvAssistants.DataSource = allAssistants;
                dgvAssistants.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assistants: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAssistant_Click(object sender, EventArgs e)
        {
            AddEditAssistantForm addForm = new AddEditAssistantForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllAssistants(); // Refresh the list after adding
                LoadDashboardOverview(); // Update counts
            }
        }

        private void btnEditAssistant_Click(object sender, EventArgs e)
        {
            if (dgvAssistants.SelectedRows.Count > 0)
            {
                int selectedAssistantId = (int)dgvAssistants.SelectedRows[0].Cells["AssistantID"].Value;
                AddEditAssistantForm editForm = new AddEditAssistantForm(selectedAssistantId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllAssistants(); // Refresh the list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select an assistant to edit.", "No Assistant Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteAssistant_Click(object sender, EventArgs e)
        {
            if (dgvAssistants.SelectedRows.Count > 0)
            {
                int selectedAssistantId = (int)dgvAssistants.SelectedRows[0].Cells["AssistantID"].Value;
                string assistantName = $"{dgvAssistants.SelectedRows[0].Cells["FirstName"].Value} {dgvAssistants.SelectedRows[0].Cells["LastName"].Value}";

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete assistant '{assistantName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (_assistantService.DeleteAssistant(selectedAssistantId))
                        {
                            MessageBox.Show("Assistant deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllAssistants(); // Refresh the list
                            LoadDashboardOverview(); // Update counts
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete assistant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException ex) // Catch if assistant is in use
                    {
                        MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an assistant to delete.", "No Assistant Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllContainers()
        {
            try
            {
                List<Models.Container> allContainers = _containerService.GetAllContainers();
                dgvContainers.DataSource = allContainers;
                dgvContainers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading containers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            AddEditContainerForm addForm = new AddEditContainerForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadAllContainers(); // Refresh the list after adding
                LoadDashboardOverview(); // Update counts
            }
        }

        private void btnEditContainer_Click(object sender, EventArgs e)
        {
            if (dgvContainers.SelectedRows.Count > 0)
            {
                int selectedContainerId = (int)dgvContainers.SelectedRows[0].Cells["ContainerID"].Value;
                AddEditContainerForm editForm = new AddEditContainerForm(selectedContainerId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllContainers(); // Refresh the list after editing
                }
            }
            else
            {
                MessageBox.Show("Please select a container to edit.", "No Container Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            if (dgvContainers.SelectedRows.Count > 0)
            {
                int selectedContainerId = (int)dgvContainers.SelectedRows[0].Cells["ContainerID"].Value;
                string containerNumber = dgvContainers.SelectedRows[0].Cells["ContainerNumber"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete container '{containerNumber}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (_containerService.DeleteContainer(selectedContainerId))
                        {
                            MessageBox.Show("Container deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllContainers(); // Refresh the list
                            LoadDashboardOverview(); // Update counts
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete container.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a container to delete.", "No Container Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewJobDetails_Click_1(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                JobDetailsForm jobDetailsForm = new JobDetailsForm(selectedJobId, _jobService, _customerService);
                if (jobDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllJobs();
                    LoadDashboardOverview();
                }
            }
            else
            {
                MessageBox.Show("Please select a job to view details.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAssignTransportUnit_Click_1(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                AssignTransportUnitForm assignForm = new AssignTransportUnitForm(selectedJobId, _jobService, _transportUnitService, _lorryService, _driverService, _assistantService, _containerService, _notificationService, _customerService, _emailService);
                if (assignForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllJobs();
                    LoadDashboardOverview();
                }
            }
            else
            {
                MessageBox.Show("Please select a job to assign a transport unit.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateJobStatus_Click_1(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                string currentJobStatus = dgvJobs.SelectedRows[0].Cells["JobStatus"].Value.ToString();

                string newStatus = PromptForNewJobStatus(currentJobStatus);
                if (!string.IsNullOrEmpty(newStatus) && newStatus != currentJobStatus)
                {
                    try
                    {
                        if (_jobService.UpdateJobStatus(selectedJobId, newStatus))
                        {
                            MessageBox.Show("Job status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllJobs();
                            LoadDashboardOverview();

                            Job updatedJob = _jobService.GetJobById(selectedJobId);
                            if (updatedJob != null && updatedJob.CustomerID.HasValue)
                            {
                                Customer customer = _customerService.GetCustomerById(updatedJob.CustomerID.Value);
                                if (customer != null && customer.UserID.HasValue)
                                {
                                    _notificationService.AddNotification(new Notification
                                    {
                                        UserID = customer.UserID.Value,
                                        MessageType = "Job_StatusUpdate",
                                        MessageContent = $"Your job '{updatedJob.JobNumber}' has been updated to status: '{newStatus}'.",
                                        RelatedEntityID = selectedJobId,
                                        RelatedEntityType = "Job"
                                    });
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update job status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating job status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a job to update its status.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string PromptForNewJobStatus(string currentStatus)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Update Job Status",
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Select new status:" };
            ComboBox comboBox = new ComboBox() { Left = 50, Top = 50, Width = 200, Height = 50, DropDownStyle = ComboBoxStyle.DropDownList };
            string[] statuses = new string[] { "Pending", "Quoted", "Scheduled", "In Progress", "Completed", "Cancelled", "Delivered" };
            comboBox.Items.AddRange(statuses);
            comboBox.SelectedItem = currentStatus;

            Button confirmation = new Button() { Text = "Change", Left = 150, Width = 100, Top = 90, Height = 40, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? comboBox.SelectedItem?.ToString() : string.Empty;
        }

        private void LoadAdminNotifications()
        {
            try
            {
                List<Notification> notifications = _notificationService.GetUnreadNotificationsForUser(_currentAdminUserId);
                dgvNotifications.DataSource = notifications;

                if (notifications.Count > 0)
                {
                    lblNotificationCount.Text = notifications.Count.ToString();
                }
                else
                {
                    lblNotificationCount.Text = "0";
                }
                dgvNotifications.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (dgvNotifications.SelectedRows.Count > 0)
            {
                int notificationId = (int)dgvNotifications.SelectedRows[0].Cells["NotificationID"].Value;
                try
                {
                    if (_notificationService.MarkNotificationAsRead(notificationId))
                    {
                        MessageBox.Show("Notification marked as read.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdminNotifications();
                    }
                    else
                    {
                        MessageBox.Show("Failed to mark notification as read.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error marking notification as read: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a notification to mark as read.", "No Notification Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshNotifications_Click(object sender, EventArgs e)
        {
            LoadAdminNotifications(); // Simply refresh the notifications list
            MessageBox.Show("Notifications refreshed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private async void btnJobsPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = await _reportService.GenerateJobsPdfReportAsync())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files (*.pdf)|*.pdf",
                        FileName = "JobsReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf",
                        Title = "Save Jobs PDF Report"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                        MessageBox.Show("Jobs PDF report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or saving PDF report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnJobsExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = await _reportService.GenerateJobsExcelReportAsync())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "JobsReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx",
                        Title = "Save Jobs Excel Report"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                        MessageBox.Show("Jobs Excel report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or saving Excel report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCustomersPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = await _reportService.GenerateCustomersPdfReportAsync())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files (*.pdf)|*.pdf",
                        FileName = "CustomersReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf",
                        Title = "Save Customers PDF Report"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                        MessageBox.Show("Customers PDF report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or saving Customer PDF report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCustomersExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = await _reportService.GenerateCustomersExcelReportAsync())
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "CustomersReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx",
                        Title = "Save Customers Excel Report"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fileStream);
                        }
                        MessageBox.Show("Customers Excel report saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or saving Customer Excel report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyCustomerFilter()
        {
            if (_allCustomersCache == null) return; // Ensure data is loaded

            string searchTerm = txtSearchCustomers.Text.Trim();
            string searchByField = cmbSearchCustomersBy.SelectedItem?.ToString();

            IEnumerable<Customer> filteredCustomers = _allCustomersCache;

            if (!string.IsNullOrWhiteSpace(searchTerm) && !string.IsNullOrWhiteSpace(searchByField))
            {
                // Perform client-side filtering using LINQ
                filteredCustomers = filteredCustomers.Where(c =>
                {
                    switch (searchByField)
                    {
                        case "Customer Number":
                            return c.CustomerNumber?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "First Name":
                            return c.FirstName?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Last Name":
                            return c.LastName?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Email":
                            return c.Email?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Phone Number":
                            return c.PhoneNumber?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        default:
                            return false; // Should not happen with proper ComboBox setup
                    }
                }).ToList();
            }

            dgvCustomers.DataSource = filteredCustomers.ToList(); // Update DataGridView
            dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ApplyJobFilter()
        {
            if (_allJobsCache == null) return; // Ensure data is loaded

            string searchTerm = txtSearchJobs.Text.Trim();
            string searchByField = cmbSearchJobsBy.SelectedItem?.ToString();

            IEnumerable<Job> filteredJobs = _allJobsCache;

            if (!string.IsNullOrWhiteSpace(searchTerm) && !string.IsNullOrWhiteSpace(searchByField))
            {
                // Perform client-side filtering using LINQ
                filteredJobs = filteredJobs.Where(j =>
                {
                    switch (searchByField)
                    {
                        case "Job Number":
                            return j.JobNumber?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Pickup Location":
                            return j.PickupLocation?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Delivery Location":
                            return j.DeliveryLocation?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        case "Job Status":
                            return j.JobStatus?.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                        default:
                            return false; // Should not happen
                    }
                }).ToList();
            }

            dgvJobs.DataSource = filteredJobs.ToList(); // Update DataGridView
            dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtSearchJobs_TextChanged(object sender, EventArgs e)
        {
            ApplyJobFilter();
        }

        private void cmbSearchJobsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyJobFilter();
        }

        private void cmbSearchCustomersBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyCustomerFilter();
        }

        private void txtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            ApplyCustomerFilter();
        }
    }
}
