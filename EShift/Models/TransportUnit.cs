using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class TransportUnit
    {
        public int TransportUnitID { get; set; }
        public int LorryID { get; set; } // Foreign Key to Lorry
        public int DriverID { get; set; } // Foreign Key to Driver
        public int? AssistantID { get; set; } // Foreign Key to Assistant
        public int? ContainerID { get; set; } // Foreign Key to Container
        public string UnitName { get; set; }
        public bool IsOperational { get; set; }
    }
}
