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
    public partial class AddEditDriverForm : Form
    {
        private readonly IDriverService _driverService;
        private int? _driverId; // Nullable int: null for Add, ID for Edit
        private Driver _currentDriver;

        // Constructor for adding a new Driver
        public AddEditDriverForm()
        {
            InitializeComponent();
            _driverService = new DriverService();
            _driverId = null; // Indicate Add mode
            this.Text = "Add New Driver";
            lblFormTitle.Text = "Add New Driver"; // Set title label
            btnSubmit.Text = "Add Driver";
            // Set default availability for new drivers
            chkIsAvailable.Checked = true;
        }

        // Constructor for editing an existing Driver
        public AddEditDriverForm(int driverId)
        {
            InitializeComponent();
            _driverService = new DriverService();
            _driverId = driverId; // Indicate Edit mode
            this.Text = "Edit Driver";
            lblFormTitle.Text = "Edit Driver"; // Set title label
            btnSubmit.Text = "Update Driver";
            LoadDriverData(); // Load existing data for editing
        }

        private void LoadDriverData()
        {
            try
            {
                _currentDriver = _driverService.GetDriverById(_driverId.Value);
                if (_currentDriver != null)
                {
                    txtFirstName.Text = _currentDriver.FirstName;
                    txtLastName.Text = _currentDriver.LastName;
                    txtLicenseNumber.Text = _currentDriver.LicenseNumber;
                    txtPhoneNumber.Text = _currentDriver.PhoneNumber;
                    txtEmail.Text = _currentDriver.Email;
                    txtAddress.Text = _currentDriver.Address;
                    chkIsAvailable.Checked = _currentDriver.IsAvailable;
                }
                else
                {
                    MessageBox.Show("Driver not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading driver data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Get input from UI
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string licenseNumber = txtLicenseNumber.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            bool isAvailable = chkIsAvailable.Checked;

            // 2. Client-side Validation
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(licenseNumber))
            {
                MessageBox.Show("First Name, Last Name, and License Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Basic email format check
            if (!string.IsNullOrEmpty(email) && (!email.Contains("@") || !email.Contains(".")))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create/Update Driver object
            Driver driverToSave = _currentDriver ?? new Driver(); // Use existing object if editing, new if adding

            driverToSave.FirstName = firstName;
            driverToSave.LastName = lastName;
            driverToSave.LicenseNumber = licenseNumber;
            driverToSave.PhoneNumber = phoneNumber;
            driverToSave.Email = email;
            driverToSave.Address = address;
            driverToSave.IsAvailable = isAvailable;

            try
            {
                bool success;
                if (_driverId.HasValue) // Edit mode
                {
                    driverToSave.DriverID = _driverId.Value; // Ensure ID is set for update
                    success = _driverService.UpdateDriver(driverToSave);
                }
                else // Add mode
                {
                    success = _driverService.AddDriver(driverToSave);
                }

                if (success)
                {
                    MessageBox.Show("Driver saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicate success to parent form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save driver. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex) // Catch business rule violations (e.g., duplicate license number)
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex) // Catch validation errors from service
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
    }
}
