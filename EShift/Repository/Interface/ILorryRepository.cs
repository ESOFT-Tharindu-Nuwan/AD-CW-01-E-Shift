using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface ILorryRepository
    {
        List<Lorry> GetAll();
        Lorry GetById(int lorryId);
        int Add(Lorry lorry); // Returns the new LorryID
        bool Update(Lorry lorry);
        bool Delete(int lorryId);
        bool ExistsByRegistrationNumber(string registrationNumber, int? excludeLorryId = null); // For unique check
        int GetAvailableLorriesCount(); // For dashboard overview
    }
}
