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
    public partial class JobDetailsForm: Form
    {
        private ICustomerService _customerService;
        private IJobService _jobService;
        private int _selectedJobId;
        public JobDetailsForm()
        {
            InitializeComponent();
        }
        public JobDetailsForm(int jobId, IJobService jobService, ICustomerService customerService)
        {
            InitializeComponent();
            _selectedJobId = jobId;
            _jobService = jobService;
            _customerService = customerService;
            LoadJobDetails();
        }

        private void LoadJobDetails()
        {
            // First, load the job details (existing logic)
            Job currentJob = _jobService.GetJobById(_selectedJobId);
            if (currentJob != null)
            {
                // Populate job-specific UI elements (e.g., txtJobNumber.Text = currentJob.JobNumber;)

                // Now, fetch and display customer details if a CustomerID exists
                if (currentJob.CustomerID.HasValue)
                {
                    Customer customer = _customerService.GetCustomerById(currentJob.CustomerID.Value);
                    if (customer != null)
                    {
                        lblCustomerNumber.Text = customer.CustomerNumber;
                        lblCustomerFirstName.Text = customer.FirstName;
                        lblCustomerLastName.Text = customer.LastName;
                        lblCustomerAddressLine1.Text = customer.AddressLine1;
                        lblCustomerAddressLine2.Text = customer.AddressLine2;
                        lblCustomerCity.Text = customer.City;
                        lblCustomerProvince.Text = customer.Province;
                        lblCustomerPostalCode.Text = customer.PostalCode;
                        lblCustomerPhoneNumber.Text = customer.PhoneNumber;
                        lblCustomerEmail.Text = customer.Email;

                        lblJobNumber.Text = currentJob.JobNumber;
                        lblDelivaryLocation.Text = currentJob.DeliveryLocation;
                        lblPickUpLocation.Text = currentJob.PickupLocation;
                        lblRequestedDate.Text = currentJob.RequestedDate.ToString("d");
                        lblPickupDate.Text = currentJob.ScheduledPickupDate?.ToString("d");
                        lblJobStatus.Text = currentJob.JobStatus;
                    }
                    else
                    {
                        ClearCustomerFields();
                        ClearJobFields();
                        lblCustomerFirstName.Text = "Customer Not Found";
                    }
                }
                else
                {
                    ClearCustomerFields();
                    ClearJobFields();
                    lblCustomerFirstName.Text = "No Customer Assigned";
                }
            }
            else
            {
                MessageBox.Show("Job not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ClearCustomerFields()
        {
            lblCustomerNumber.Text = string.Empty;
            lblCustomerFirstName.Text = string.Empty;
            lblCustomerLastName.Text = string.Empty;
            lblCustomerAddressLine1.Text = string.Empty;
            lblCustomerAddressLine2.Text = string.Empty;
            lblCustomerCity.Text = string.Empty;
            lblCustomerProvince.Text = string.Empty;
            lblCustomerPostalCode.Text = string.Empty;
            lblCustomerPhoneNumber.Text = string.Empty;
            lblCustomerEmail.Text = string.Empty;
        }

        private void ClearJobFields()
        {
            lblJobNumber.Text = string.Empty;
            lblDelivaryLocation.Text = string.Empty;
            lblPickUpLocation.Text = string.Empty;
            lblRequestedDate.Text = string.Empty;
            lblPickupDate.Text = string.Empty;
            lblJobStatus.Text = string.Empty;
        }
    }
}
