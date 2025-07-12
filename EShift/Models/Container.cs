using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class Container
    {
        public int ContainerID { get; set; }
        public string ContainerNumber { get; set; }
        public string? Type { get; set; }
        public decimal CapacityCBM { get; set; } // Cubic meters
        public bool IsAvailable { get; set; }
    }
}
