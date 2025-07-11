﻿using EShift.Business.Interface;
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
        public AdminDashboardForm()
        {
            InitializeComponent();
            _jobService = new JobService();
            LoadDashboardOverview();
            LoadAllJobs();
            _lorryService = new LorryService(); // Initialize LorryService
            LoadAllLorries();
            _driverService = new DriverService(); // Initialize DriverService
            LoadAllDrivers();
            _transportUnitService = new TransportUnitService(); // Initialize TransportUnitService
            LoadAllTransportUnits();
            _assistantService = new AssistantService(); // Initialize AssistantService.
            LoadAllAssistants();
            _containerService = new ContainerService(); // Initialize ContainerService
            LoadAllContainers();
        }

        public AdminDashboardForm(int adminUserId)
        {
            InitializeComponent();
            //_currentAdminUserId = adminUserId;
            //_userService = new UserService();
            _jobService = new JobService(); // Initialize JobService
            // ... initialize other services

            //User adminUser = _userService.GetUserById(_currentAdminUserId);
            //this.Text = $"e-Shift Admin Dashboard - Welcome, {adminUser?.Username ?? "Admin"}";

            //SetupTabs();
            LoadDashboardOverview();
            LoadAllJobs();
            _lorryService = new LorryService(); // Initialize LorryService

            LoadAllLorries();
            _driverService = new DriverService(); // Initialize DriverService
            LoadAllDrivers();
            _transportUnitService = new TransportUnitService(); // Initialize TransportUnitService
            LoadAllTransportUnits();
            _assistantService = new AssistantService(); // Initialize AssistantService.
            LoadAllAssistants();
            _containerService = new ContainerService(); // Initialize ContainerService
            LoadAllContainers();
        }

        private void LoadDashboardOverview()
        {
            try
            {
                lblTotalActiveJobs.Text = _jobService.GetTotalActiveJobsCount().ToString();
                lblPendingRequests.Text = _jobService.GetPendingJobRequestsCount().ToString();
                // Add similar calls for lorries, drivers, customers etc.
                // lblAvailableLorries.Text = new LorryService().GetAvailableLorriesCount().ToString();
                // lblAvailableDrivers.Text = new DriverService().GetAvailableDriversCount().ToString();
                // lblTotalCustomers.Text = new CustomerService().GetTotalCustomersCount().ToString();
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
                List<Job> allJobs = _jobService.GetAllJobs();
                dgvJobs.DataSource = allJobs; // Assuming you named your DataGridView 'dgvJobs'

                // Optional: Auto-resize columns
                dgvJobs.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Populate job status filter ComboBox
                if (cmbJobStatusFilter.Items.Count == 0)
                {
                    cmbJobStatusFilter.Items.Add("All");
                    cmbJobStatusFilter.Items.Add("Pending");
                    cmbJobStatusFilter.Items.Add("Quoted");
                    cmbJobStatusFilter.Items.Add("Scheduled");
                    cmbJobStatusFilter.Items.Add("In Progress");
                    cmbJobStatusFilter.Items.Add("Completed");
                    cmbJobStatusFilter.Items.Add("Cancelled");
                    cmbJobStatusFilter.Items.Add("Delivered"); // If you differentiate Delivered from Completed
                    cmbJobStatusFilter.SelectedIndex = 0; // Select "All" by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for View Job Details button
        private void btnViewJobDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                // Open a new form to view/edit job details
                // You will need to create JobDetailsForm
                //JobDetailsForm jobDetailsForm = new JobDetailsForm(selectedJobId);
                //jobDetailsForm.ShowDialog(); // Show as modal dialog
                LoadAllJobs(); // Refresh job list after potential edits
            }
            else
            {
                MessageBox.Show("Please select a job to view details.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for Assign Transport Unit button
        private void btnAssignTransportUnit_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                // Open a new form to assign transport unit
                // You will need to create AssignTransportUnitForm
                //AssignTransportUnitForm assignForm = new AssignTransportUnitForm(selectedJobId);
                //assignForm.ShowDialog();
                LoadAllJobs(); // Refresh job list
            }
            else
            {
                MessageBox.Show("Please select a job to assign a transport unit.", "No Job Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for Update Job Status button
        private void btnUpdateJobStatus_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int selectedJobId = (int)dgvJobs.SelectedRows[0].Cells["JobID"].Value;
                // A simple dialog or another form to pick new status
                string newStatus = PromptForNewJobStatus(); // Implement this method
                if (!string.IsNullOrEmpty(newStatus))
                {
                    try
                    {
                        if (_jobService.UpdateJobStatus(selectedJobId, newStatus))
                        {
                            MessageBox.Show("Job status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllJobs(); // Refresh list
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

        private string PromptForNewJobStatus()
        {
            // Simple InputBox or a custom dialog form
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Update Job Status",
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Enter new status:" };
            ComboBox comboBox = new ComboBox() { Left = 50, Top = 50, Width = 200 };
            comboBox.Items.AddRange(new string[] { "Pending", "Quoted", "Scheduled", "In Progress", "Completed", "Cancelled" }); // Or fetch from a static list
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? comboBox.SelectedItem?.ToString() : string.Empty;
        }

        private void LoadAllLorries()
        {
            try
            {
                List<Lorry> allLorries = _lorryService.GetAllLorries();
                dgvLorries.DataSource = allLorries; // Assuming you have a DataGridView named 'dgvLorries' on tabPageResources
                dgvLorries.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lorries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Add Lorry button
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
                dgvDrivers.DataSource = allDrivers; // Assuming you have a DataGridView named 'dgvDrivers' on tabPageResources
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
                dgvTransportUnits.DataSource = allUnits; // Assuming you have a DataGridView named 'dgvTransportUnits' on tabPageResources
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
                    catch (InvalidOperationException ex) // Catch if unit is in use
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
                dgvAssistants.DataSource = allAssistants; // Assuming you have a DataGridView named 'dgvAssistants' on tabPageResources
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
                dgvContainers.DataSource = allContainers; // Assuming you have a DataGridView named 'dgvContainers' on tabPageResources
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
                    catch (InvalidOperationException ex) // Catch if container is in use
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
    }
}
