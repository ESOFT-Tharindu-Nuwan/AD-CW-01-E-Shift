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

        public JobService()
        {
            _jobRepository = new JobRepository();
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
            return _jobRepository.Update(job);
        }

        public bool UpdateJobStatus(int jobId, string newStatus)
        {
            if (string.IsNullOrEmpty(newStatus))
            {
                throw new ArgumentException("Job status cannot be empty.");
            }
            // Add more validation for valid statuses if needed
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
            // Basic validation
            if (string.IsNullOrEmpty(job.PickupLocation) || string.IsNullOrEmpty(job.DeliveryLocation) || job.CustomerID <= 0)
            {
                throw new ArgumentException("Job must have valid locations and customer.");
            }
            if (string.IsNullOrEmpty(initialLoad.Description))
            {
                throw new ArgumentException("Load must have a description.");
            }

            // Ensure JobNumber and LoadNumber are generated before saving
            job.JobNumber = _jobRepository.GetNextJobNumber();
            initialLoad.LoadNumber = _jobRepository.GetNextLoadNumber();

            job.RequestedDate = DateTime.Now;
            job.JobStatus = "Pending"; // Initial status
            initialLoad.LoadStatus = "Packed"; // Initial load status

            try
            {
                int newJobId = _jobRepository.Add(job);
                if (newJobId > 0)
                {
                    initialLoad.JobID = newJobId;
                    _jobRepository.AddLoad(initialLoad);
                    // Optionally, add a notification for the admin about a new job request
                    // new NotificationService().AddNotification(new Notification {
                    //    UserID = ADMIN_USER_ID, // You'd need to fetch Admin UserID
                    //    MessageType = "Job_NewRequest",
                    //    MessageContent = $"New job request from customer {job.CustomerID}. Job No: {job.JobNumber}",
                    //    RelatedEntityID = newJobId,
                    //    RelatedEntityType = "Job"
                    // });
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error in AddJob: {ex.Message}");
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
            return _jobRepository.GetJobsByCustomerId(customerId);
        }
    }
}
