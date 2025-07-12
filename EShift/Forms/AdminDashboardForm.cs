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
        public AdminDashboardForm()
        {
            InitializeComponent();
            _jobService = new JobService();
            LoadDashboardOverview();
            LoadAllJobs();
            // ... load other tabs
            _lorryService = new LorryService(); // Initialize LorryService

            // ... existing Load methods ...
            LoadAllLorries();
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
            // ... load other tabs
            _lorryService = new LorryService(); // Initialize LorryService

            // ... existing Load methods ...
            LoadAllLorries();
        }

        // ... (SetupTabs and other Load methods)

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

        // Event handler for Edit Lorry button


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

        // Event handler for Delete Lorry button

    }
}
