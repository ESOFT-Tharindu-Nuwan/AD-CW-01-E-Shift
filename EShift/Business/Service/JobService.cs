using EShift.Business.Interface;
using EShift.Models;
using EShift.Repository.Interface;
using EShift.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly INotificationService _notificationService;

        public JobService()
        {
            _jobRepository = new JobRepository();
            _notificationService = new NotificationService();
        }

        public List<Job> GetAllJobs()
        {
            return _jobRepository.GetAll();
        }

        public Job GetJobById(int jobId)
        {
            return _jobRepository.GetById(jobId);
        }

        public bool UpdateJob(Job job)
        {
            if (job == null)
            {
                throw new ArgumentNullException(nameof(job), "Job object cannot be null for update.");
            }
            if (string.IsNullOrEmpty(job.PickupLocation) || string.IsNullOrEmpty(job.DeliveryLocation))
            {
                throw new ArgumentException("Pickup and Delivery locations cannot be empty.");
            }
            if (job.JobID <= 0)
            {
                throw new ArgumentException("Invalid Job ID for update operation.");
            }

            return _jobRepository.Update(job);
        }

        public bool UpdateJobStatus(int jobId, string newStatus)
        {
            if (string.IsNullOrEmpty(newStatus))
            {
                throw new ArgumentException("Job status cannot be empty.");
            }
            if (jobId <= 0)
            {
                throw new ArgumentException("Invalid Job ID for status update.");
            }
            // Optional: Add more validation for valid status transitions (e.g., cannot go from 'Completed' to 'Pending')
            // string currentStatus = GetJobById(jobId)?.JobStatus;
            // if (currentStatus == "Completed" && newStatus != "Completed") { throw new InvalidOperationException("Cannot change status of a completed job."); }

            return _jobRepository.UpdateStatus(jobId, newStatus);
        }

        public bool AssignTransportUnitToJob(int jobId, int transportUnitId, DateTime adminAssignedDate)
        {
            if (jobId <= 0 || transportUnitId <= 0)
            {
                throw new ArgumentException("Job ID and Transport Unit ID must be valid.");
            }
            return _jobRepository.AssignTransportUnit(jobId, transportUnitId, adminAssignedDate);
        }

        public int GetTotalActiveJobsCount()
        {
            return _jobRepository.GetActiveJobsCount();
        }

        public int GetPendingJobRequestsCount()
        {
            return _jobRepository.GetPendingRequestsCount();
        }

        public bool AddJob(Job job, Load initialLoad)
        {
            if (job == null || initialLoad == null)
            {
                throw new ArgumentNullException("Job and Load details cannot be null.");
            }
            // Basic validation (more comprehensive than before)
            if (string.IsNullOrEmpty(job.PickupLocation) || string.IsNullOrEmpty(job.DeliveryLocation))
            {
                throw new ArgumentException("Pickup and Delivery locations are required.");
            }
            if (job.CustomerID <= 0)
            {
                throw new ArgumentException("Job must be associated with a valid customer.");
            }
            if (string.IsNullOrEmpty(initialLoad.Description))
            {
                throw new ArgumentException("Load description is required.");
            }
            if (initialLoad.WeightKG <= 0 || initialLoad.VolumeCBM <= 0)
            {
                throw new ArgumentException("Load weight and volume must be greater than zero.");
            }
            if (job.ScheduledPickupDate == null || job.ScheduledPickupDate.Value < DateTime.Today)
            {
                throw new ArgumentException("Scheduled pickup date must be a valid date and not in the past.");
            }


            // Ensure JobNumber and LoadNumber are generated before saving
            job.JobNumber = _jobRepository.GetNextJobNumber();
            initialLoad.LoadNumber = _jobRepository.GetNextLoadNumber();

            job.RequestedDate = DateTime.Now;
            job.JobStatus = "Pending"; // Initial status for new customer requests
            initialLoad.LoadStatus = "Pending"; // Initial load status

            try
            {
                int newJobId = _jobRepository.Add(job);
                if (newJobId > 0)
                {
                    initialLoad.JobID = newJobId;
                    _jobRepository.AddLoad(initialLoad);

                    // *** UNCOMMENTED AND IMPLEMENTED NOTIFICATION LOGIC ***
                    try
                    {
                        int adminUserId = _notificationService.GetAdminUserId(); // Get the ID of an admin user
                        if (adminUserId > 0)
                        {
                            _notificationService.AddNotification(new Notification
                            {
                                UserID = adminUserId,
                                MessageType = "Job_NewRequest",
                                MessageContent = $"New job request from customer (ID: {job.CustomerID}, Job No: {job.JobNumber}). Pickup: {job.PickupLocation}, Delivery: {job.DeliveryLocation}.",
                                RelatedEntityID = newJobId,
                                RelatedEntityType = "Job"
                            });
                        }
                        else
                        {
                            Console.WriteLine("Warning: No admin user found to send new job request notification to.");
                            // Consider logging this warning more robustly (e.g., to a file or database log)
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine($"Error getting Admin User ID for notification: {ex.Message}");
                        // Log this, but don't prevent job creation from succeeding
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error sending new job notification: {ex.Message}");
                        // Log this, but don't prevent job creation from succeeding
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddJob: {ex.Message}");
                // Log the exception for debugging
                throw; // Re-throw for UI to catch
            }
        }

        public string GenerateJobNumber()
        {
            return _jobRepository.GetNextJobNumber();
        }

        public string GenerateLoadNumber()
        {
            return _jobRepository.GetNextLoadNumber();
        }

        // Add GetJobsByCustomerId to service
        public List<Job> GetJobsByCustomerId(int customerId)
        {
            if (customerId <= 0)
            {
                throw new ArgumentException("Invalid Customer ID.");
            }
            return _jobRepository.GetJobsByCustomerId(customerId);
        }
    }
}
