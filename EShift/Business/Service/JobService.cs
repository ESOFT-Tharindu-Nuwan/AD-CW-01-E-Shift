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
    }
}
