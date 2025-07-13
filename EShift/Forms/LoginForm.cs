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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _emailService = new EmailService();

            txtPassword.PasswordChar = '*';
            this.MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Do not trim password if leading/trailing spaces are meaningful

            // Client-side validation for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Call the Business Service to authenticate the user
                User authenticatedUser = _userService.AuthenticateUser(username, password);

                if (authenticatedUser != null)
                {
                    // Authentication successful
                    MessageBox.Show($"Welcome, {authenticatedUser.Username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect based on user role
                    if (authenticatedUser.UserRole == "Admin")
                    {
                        // Assuming you have an AdminDashboardForm
                        AdminDashboardForm adminDashboard = new AdminDashboardForm(authenticatedUser.UserID, _emailService);
                        adminDashboard.Show();
                    }
                    else if (authenticatedUser.UserRole == "Customer")
                    {
                        // Assuming you have a CustomerDashboardForm
                        // Pass the UserID to the CustomerDashboardForm to load user-specific data
                        CustomerDashboardForm customerDashboard = new CustomerDashboardForm(authenticatedUser.UserID);
                        customerDashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown user role. Please contact support.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    this.Hide(); // Hide the login form after successful login and redirection
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear(); // Clear password field for security
                    txtUsername.Focus(); // Set focus back to username for retry
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"An error occurred during login: {ex.Message}");
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Register Form
            RegisterForm registrationForm = new RegisterForm(); // Use the corrected form name
            registrationForm.Show();
            this.Hide(); // Hide the login form temporarily
        }

    }
}
