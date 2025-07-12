using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; } // Foreign Key to User (recipient of notification)
        public string MessageType { get; set; } // e.g., "Registration_NewCustomer", "Job_NewRequest"
        public string MessageContent { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; }
        public int? RelatedEntityID { get; set; } // e.g., CustomerID or JobID, nullable
        public string? RelatedEntityType { get; set; } // e.g., "Customer", "Job", nullable
    }
}
