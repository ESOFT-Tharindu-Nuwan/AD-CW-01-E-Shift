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
    public partial class AddEditAssistantForm : Form
    {
        private readonly IAssistantService _assistantService;
        private int? _assistantId; // Nullable int: null for Add, ID for Edit
        private Assistant _currentAssistant;

        public AddEditAssistantForm()
        {
            InitializeComponent();
            _assistantService = new AssistantService();
            _assistantId = null; // Indicate Add mode
            this.Text = "Add New Assistant";
            lblFormTitle.Text = "Add New Assistant"; // Set title label
            btnSubmit.Text = "Add Assistant";
            // Set default availability for new assistants
            chkIsAvailable.Checked = true;
        }

        public AddEditAssistantForm(int assistantId)
        {
            InitializeComponent();
            _assistantService = new AssistantService();
            _assistantId = assistantId; // Indicate Edit mode
            this.Text = "Edit Assistant";
            lblFormTitle.Text = "Edit Assistant"; // Set title label
            btnSubmit.Text = "Update Assistant";
            LoadAssistantData(); // Load existing data for editing
        }

        private void LoadAssistantData()
        {
            try
            {
                _currentAssistant = _assistantService.GetAssistantById(_assistantId.Value);
                if (_currentAssistant != null)
                {
                    txtFirstName.Text = _currentAssistant.FirstName;
                    txtLastName.Text = _currentAssistant.LastName;
                    txtPhoneNumber.Text = _currentAssistant.PhoneNumber;
                    txtEmail.Text = _currentAssistant.Email;
                    txtAddress.Text = _currentAssistant.Address;
                    chkIsAvailable.Checked = _currentAssistant.IsAvailable;
                }
                else
                {
                    MessageBox.Show("Assistant not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading assistant data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Get input from UI
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            bool isAvailable = chkIsAvailable.Checked;

            // 2. Client-side Validation
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Basic email format check
            if (!string.IsNullOrEmpty(email) && (!email.Contains("@") || !email.Contains(".")))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create/Update Assistant object
            Assistant assistantToSave = _currentAssistant ?? new Assistant(); // Use existing object if editing, new if adding

            assistantToSave.FirstName = firstName;
            assistantToSave.LastName = lastName;
            assistantToSave.PhoneNumber = phoneNumber;
            assistantToSave.Email = email;
            assistantToSave.Address = address;
            assistantToSave.IsAvailable = isAvailable;

            try
            {
                bool success;
                if (_assistantId.HasValue) // Edit mode
                {
                    assistantToSave.AssistantID = _assistantId.Value; // Ensure ID is set for update
                    success = _assistantService.UpdateAssistant(assistantToSave);
                }
                else // Add mode
                {
                    success = _assistantService.AddAssistant(assistantToSave);
                }

                if (success)
                {
                    MessageBox.Show("Assistant saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicate success to parent form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save assistant. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex) // Catch validation errors from service
            {
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
