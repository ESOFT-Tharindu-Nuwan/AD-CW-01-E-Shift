using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface ILorryService
    {
        List<Lorry> GetAllLorries();
        Lorry GetLorryById(int lorryId);
        bool AddLorry(Lorry lorry);
        bool UpdateLorry(Lorry lorry);
        bool DeleteLorry(int lorryId);
        int GetAvailableLorriesCount();
    }
}
