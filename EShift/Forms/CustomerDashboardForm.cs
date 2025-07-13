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
    public partial class CustomerDashboardForm : Form
    {
        private readonly IJobService _jobService;
        private readonly int _loggedInCustomerId;
        private readonly INotificationService _notificationService;
        private readonly ICustomerService _customerService;
        private readonly IUserService _userService;
        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        public CustomerDashboardForm(int customerId)
        {
            InitializeComponent();
            _loggedInCustomerId = customerId;
            _jobService = new JobService();
            _notificationService = new NotificationService();
            _customerService = new CustomerService();
            _userService = new UserService();

            // Optional: Set default values for new job request form
            dateScheduledPickupDate.MinDate = DateTime.Today; // Cannot schedule for past dates
            dateScheduledPickupDate.Value = DateTime.Today.AddDays(1); // Default to tomorrow
            ClearNewJobForm();
            LoadAllNotifications();
            LoadAllJobs();
            LoadCustomerDetails();
        }

        private void LoadCustomerDetails()
        {
            try
            {
                Customer customer = _customerService.GetCustomerById(_loggedInCustomerId);
                User user = _userService.GetByUserId(_loggedInCustomerId);
                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtAddressLine1.Text = customer.AddressLine1;
                txtAddressLine2.Text = customer.AddressLine2;
                txtCity.Text = customer.City;
                txtProvince.Text = customer.Province;
                txtPostalCode.Text = customer.PostalCode;
                txtEmail.Text = customer.Email;
                txtPhoneNumber.Text = customer.PhoneNumber;
                txtUsername.Text = user.Username;
                lblLoggedUsername.Text = user.Username;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllJobs()
        {
            try
            {
                List<Job> allJobs = _jobService.GetJobsByCustomerId(_loggedInCustomerId);
                dgvMyJobs.DataSource = allJobs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading jobs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadAllNotifications()
        {
            try
            {
                List<Notification> customerNotifications = _notificationService.GetUnreadNotificationsForUser(_loggedInCustomerId);
                dgvCustomerNotifications.DataSource = customerNotifications;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Collect data from form controls
            string pickupLocation = txtPickupLocation.Text.Trim();
            string deliveryLocation = txtDeliveryLocation.Text.Trim();
            DateTime scheduledPickupDate = dateScheduledPickupDate.Value;
            string loadDescription = txtDescription.Text.Trim();
            string specialInstructions = txtSpecialInstructions.Text.Trim();

            // Validate numeric inputs for weight and volume
            if (!decimal.TryParse(txtWeightKG.Text.Trim(), out decimal weightKG))
            {
                MessageBox.Show("Please enter a valid number for Weight (KG).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeightKG.Focus();
                return;
            }
            if (!decimal.TryParse(txtVolumeCBM.Text.Trim(), out decimal volumeCBM))
            {
                MessageBox.Show("Please enter a valid number for Volume (CBM).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVolumeCBM.Focus();
                return;
            }

            // 2. Create Job and Load objects
            Job newJob = new Job
            {
                CustomerID = _loggedInCustomerId, // Crucial: Assign the logged-in customer's ID
                PickupLocation = pickupLocation,
                DeliveryLocation = deliveryLocation,
                ScheduledPickupDate = scheduledPickupDate,
                // Other fields will be set by the service or admin later
                // JobStatus will be set to "Pending" by the service
                Remarks = "" // Customer can't add remarks at this stage
            };

            Load initialLoad = new Load
            {
                Description = loadDescription,
                WeightKG = weightKG,
                VolumeCBM = volumeCBM,
                SpecialInstructions = specialInstructions
                // LoadStatus will be set to "Packed" by the service
            };

            // 3. Call the service to add the job
            try
            {
                bool success = _jobService.AddJob(newJob, initialLoad);

                if (success)
                {
                    MessageBox.Show("Job request submitted successfully! Your job number is: " + newJob.JobNumber, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearNewJobForm(); // Clear the form after successful submission
                    // Optional: Refresh a 'My Jobs' DataGridView if you have one on another tab
                    // LoadCustomerJobs(_loggedInCustomerId);
                }
                else
                {
                    MessageBox.Show("Failed to submit job request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex) // Catch validation errors from the service
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex) // Catch business rule violations (if any are added)
            {
                MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearNewJobForm();
        }

        private void ClearNewJobForm()
        {
            txtPickupLocation.Clear();
            txtDeliveryLocation.Clear();
            dateScheduledPickupDate.Value = DateTime.Today.AddDays(1); // Reset to tomorrow
            txtDescription.Clear();
            txtWeightKG.Clear();
            txtVolumeCBM.Clear();
            txtSpecialInstructions.Clear();
            txtPickupLocation.Focus(); // Set focus to the first field
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            this.Close();
        }
    }
}
