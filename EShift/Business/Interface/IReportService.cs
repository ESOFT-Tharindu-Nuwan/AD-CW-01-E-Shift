using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IReportService
    {
        Task<MemoryStream> GenerateJobsPdfReportAsync();
        Task<MemoryStream> GenerateJobsExcelReportAsync();
        Task<MemoryStream> GenerateCustomersPdfReportAsync();
        Task<MemoryStream> GenerateCustomersExcelReportAsync();
    }
}
