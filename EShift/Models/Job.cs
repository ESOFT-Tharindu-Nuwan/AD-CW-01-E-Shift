using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class Job
    {
        public int JobID { get; set; }
        public string JobNumber { get; set; }
        public int? CustomerID { get; set; } // Foreign Key to Customer
        public DateTime RequestedDate { get; set; }
        public DateTime? ScheduledPickupDate { get; set; }
        public DateTime? ScheduledDeliveryDate { get; set; }
        public DateTime? ActualPickupDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public string JobStatus { get; set; } // e.g., "Pending", "Scheduled", "Completed"
        public int? TransportUnitID { get; set; } // Foreign Key to TransportUnit, nullable
        public decimal? QuotedPrice { get; set; }
        public decimal? FinalPrice { get; set; }
        public string? Remarks { get; set; }
        public DateTime? AdminAssignedDate { get; set; }
    }
}
