using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class Load
    {
        public int LoadID { get; set; }
        public required string LoadNumber { get; set; }
        public int JobID { get; set; } // Foreign Key to Job
        public string? Description { get; set; }
        public decimal WeightKG { get; set; }
        public decimal VolumeCBM { get; set; }
        public string? LoadStatus { get; set; } // e.g., "Packed", "Loaded", "Delivered"
        public string? SpecialInstructions { get; set; }
    }
}
