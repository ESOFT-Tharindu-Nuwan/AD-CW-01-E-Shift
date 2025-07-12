using EShift.Business.Interface;
using EShift.Business.Service;
using EShift.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShift.Forms
{
    public partial class AddEditContainerForm : Form
    {
        private readonly IContainerService _containerService;
        private int? _containerId; // Nullable int: null for Add, ID for Edit
        private Container _currentContainer;
        public AddEditContainerForm()
        {
            InitializeComponent();
            _containerService = new ContainerService();
            _containerId = null; // Indicate Add mode
            this.Text = "Add New Container";
            lblFormTitle.Text = "Add New Container"; // Set title label
            btnSubmit.Text = "Add Container";
            // Set default availability for new containers
            chkIsAvailable.Checked = true;
        }

        public AddEditContainerForm(int containerId)
        {
            InitializeComponent();
            _containerService = new ContainerService();
            _containerId = containerId; // Indicate Edit mode
            this.Text = "Edit Container";
            lblFormTitle.Text = "Edit Container"; // Set title label
            btnSubmit.Text = "Update Container";
            LoadContainerData(); // Load existing data for editing
        }

        private void LoadContainerData()
        {
            try
            {
                _currentContainer = _containerService.GetContainerById(_containerId.Value);
                if (_currentContainer != null)
                {
                    txtContainerNumber.Text = _currentContainer.ContainerNumber;
                    txtType.Text = _currentContainer.Type;
                    txtCapacityCBM.Text = _currentContainer.CapacityCBM.ToString(); // Handle nullable decimal
                    chkIsAvailable.Checked = _currentContainer.IsAvailable;
                }
                else
                {
                    MessageBox.Show("Container not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading container data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Get input from UI
            string containerNumber = txtContainerNumber.Text.Trim();
            string type = txtType.Text.Trim();
            decimal? capacityCBM = null;
            if (decimal.TryParse(txtCapacityCBM.Text.Trim(), out decimal cbm)) capacityCBM = cbm;
            bool isAvailable = chkIsAvailable.Checked;

            // 2. Client-side Validation
            if (string.IsNullOrEmpty(containerNumber))
            {
                MessageBox.Show("Container Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(txtCapacityCBM.Text.Trim()) && capacityCBM == null)
            {
                MessageBox.Show("Please enter a valid number for Capacity (CBM).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Create/Update Container object
            Container containerToSave = _currentContainer ?? new Container(); // Use existing object if editing, new if adding

            containerToSave.ContainerNumber = containerNumber;
            containerToSave.Type = type;
            containerToSave.CapacityCBM = (decimal)capacityCBM;
            containerToSave.IsAvailable = isAvailable;

            try
            {
                bool success;
                if (_containerId.HasValue) // Edit mode
                {
                    containerToSave.ContainerID = _containerId.Value; // Ensure ID is set for update
                    success = _containerService.UpdateContainer(containerToSave);
                }
                else // Add mode
                {
                    success = _containerService.AddContainer(containerToSave);
                }

                if (success)
                {
                    MessageBox.Show("Container saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Indicate success to parent form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save container. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex) // Catch business rule violations (e.g., duplicate container number)
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
