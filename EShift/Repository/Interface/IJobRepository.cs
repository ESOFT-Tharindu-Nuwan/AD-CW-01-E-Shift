using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface IJobRepository
    {
        List<Job> GetAll();
        Job GetById(int jobId);
        bool Update(Job job);
        bool UpdateStatus(int jobId, string newStatus);
        bool AssignTransportUnit(int jobId, int transportUnitId, DateTime adminAssignedDate);
        int GetActiveJobsCount();
        int GetPendingRequestsCount();
    }
}
