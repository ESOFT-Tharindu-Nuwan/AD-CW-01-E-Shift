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
    public partial class AddEditLorryForm : Form
    {
        private readonly ILorryService _lorryService;
        private int? _lorryId; // Nullable int: null for Add, ID for Edit
        private Lorry _currentLorry;

        // Constructor for adding a new Lorry
        public AddEditLorryForm()
        {
            InitializeComponent();
            _lorryService = new LorryService();
            _lorryId = null; // Indicate Add mode
            this.Text = "Add New Lorry";
            lblFormTitle.Text = "Add New Lorry"; // Set title label
            btnSave.Text = "Add Lorry";
            // Set default availability for new lorries
            chkIsAvailable.Checked = true;
        }

        // Constructor for editing an existing Lorry
        public AddEditLorryForm(int lorryId)
        {
            InitializeComponent();
            _lorryService = new LorryService();
            _lorryId = lorryId; // Indicate Edit mode
            this.Text = "Edit Lorry";
            lblFormTitle.Text = "Edit Lorry"; // Set title label
            btnSave.Text = "Update Lorry";
            LoadLorryData(); // Load existing data for editing
        }

        private void LoadLorryData()
        {
            try
            {
                _currentLorry = _lorryService.GetLorryById(_lorryId.Value);
                if (_currentLorry != null)
                {
                    txtRegistrationNumber.Text = _currentLorry.RegistrationNumber;
                    txtMake.Text = _currentLorry.Make;
                    txtModel.Text = _currentLorry.Model;
                    txtCapacity.Text = _currentLorry.Capacity.ToString(); // Handle nullable decimal
                    txtFuelType.Text = _currentLorry.FuelType;
                    txtCurrentMileage.Text = _currentLorry.CurrentMileage.ToString(); // Handle nullable decimal
                    chkIsAvailable.Checked = _currentLorry.IsAvailable;
                }
                else
                {
                    MessageBox.Show("Lorry not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading lorry data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string registrationNumber = txtRegistrationNumber.Text.Trim();
            string make = txtMake.Text.Trim();
            string model = txtModel.Text.Trim();
            decimal? capacity = null;
            if (decimal.TryParse(txtCapacity.Text.Trim(), out decimal cap)) capacity = cap;
            string fuelType = txtFuelType.Text.Trim();
            decimal? currentMileage = null;
            if (decimal.TryParse(txtCurrentMileage.Text.Trim(), out decimal mileage)) currentMileage = mileage;
            bool isAvailable = chkIsAvailable.Checked;

            // 2. Client-side Validation
            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Registration Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtCapacity.Text.Trim()) && capacity == null)
            {
                MessageBox.Show("Please enter a valid number for Capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtCurrentMileage.Text.Trim()) && currentMileage == null)
            {
                MessageBox.Show("Please enter a valid number for Current Mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create/Update Lorry object
            Lorry lorryToSave = _currentLorry ?? new Lorry { RegistrationNumber = registrationNumber }; // Use existing object if editing, new if adding
            lorryToSave.RegistrationNumber = registrationNumber;
            lorryToSave.Make = make;
            lorryToSave.Model = model;
            lorryToSave.Capacity = (decimal)capacity;
            lorryToSave.FuelType = fuelType;
            lorryToSave.CurrentMileage = (decimal)currentMileage;
            lorryToSave.IsAvailable = isAvailable;

            try
            {
                bool success;
                if (_lorryId.HasValue) // Edit mode
                {
                    lorryToSave.LorryID = _lorryId.Value; // Ensure ID is set for update
                    success = _lorryService.UpdateLorry(lorryToSave);
                }
                else // Add mode
                {
                    success = _lorryService.AddLorry(lorryToSave);
                }

                if (success)
                {
                    MessageBox.Show("Lorry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicate success to parent form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save lorry. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex) // Catch business rule violations (e.g., duplicate reg number)
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
