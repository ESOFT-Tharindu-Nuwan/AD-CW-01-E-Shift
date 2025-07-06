using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Models
{
    public class Lorry
    {
        public int LorryID { get; set; }
        public required string RegistrationNumber { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public decimal Capacity { get; set; }
        public string? FuelType { get; set; }
        public decimal CurrentMileage { get; set; }
        public bool IsAvailable { get; set; }
    }
}
