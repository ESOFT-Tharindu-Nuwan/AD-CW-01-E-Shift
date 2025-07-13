using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IJobService
    {
        List<Job> GetAllJobs();
        Job GetJobById(int jobId);
        bool UpdateJob(Job job);
        bool UpdateJobStatus(int jobId, string newStatus);
        bool AssignTransportUnitToJob(int jobId, int transportUnitId, DateTime adminAssignedDate);
        int GetTotalActiveJobsCount();
        int GetPendingJobRequestsCount();
        bool AddJob(Job job, Load initialLoad);
        string GenerateJobNumber();
        string GenerateLoadNumber();
        List<Job> GetJobsByCustomerId(int customerId);
    }
}
