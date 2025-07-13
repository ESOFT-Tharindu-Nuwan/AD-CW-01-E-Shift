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
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();

            // Set password textboxes to use password char for security
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            this.MaximizeBox = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 1. Get input from form fields
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Passwords should not be trimmed for comparison
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string addressLine1 = txtAddressLine1.Text.Trim();
            string addressLine2 = txtAddressLine2.Text.Trim(); // Optional, can be empty
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();

            // 2. Client-side Input Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(addressLine1) ||
                string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6) // Basic password length check
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Basic email format check (consider using System.Net.Mail.MailAddress for robust validation)
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create Customer Model Object from form data
            Customer newCustomer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                AddressLine1 = addressLine1,
                AddressLine2 = addressLine2,
                City = city,
                Province = province,
                PostalCode = postalCode,
                PhoneNumber = phoneNumber,
                Email = email,
                CustomerNumber = string.Empty
                // UserID, CustomerNumber, and RegistrationDate will be set by the UserService
            };

            try
            {
                // 4. Call the Business Service to register the customer
                // The service handles creating the User record, hashing password, and Customer record.
                bool registrationSuccess = _userService.RegisterCustomer(username, password, newCustomer);

                if (registrationSuccess)
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form fields after successful registration
                    ClearFormFields();

                    // Navigate back to the Login Form
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close(); // Close the current registration form
                }
                else
                {
                    // This path might be hit if the service returns false for an unhandled reason
                    MessageBox.Show("Registration failed due to an internal issue. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Catch specific exceptions thrown by the Business Service for user feedback
            catch (InvalidOperationException ex) // e.g., username/email already exists
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex) // e.g., invalid password format passed to service
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // Catch all other unexpected errors
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"An unexpected error occurred during registration: {ex.Message}");
                MessageBox.Show($"An unexpected error occurred during registration. Please try again or contact support. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Navigate back to the Login Form without registering
            GoToLoginForm();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the Login Form when the "LOGIN" link is clicked
            GoToLoginForm();
        }

        private void GoToLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close(); // Close the current registration form
        }

        private void ClearFormFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtPostalCode.Clear();
            txtUsername.Focus(); // Set focus back to username
        }
    }
}
