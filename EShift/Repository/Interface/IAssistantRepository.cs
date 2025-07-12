using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface IAssistantRepository
    {
        List<Assistant> GetAll();
        Assistant GetById(int assistantId);
        int Add(Assistant assistant); // Returns the new AssistantID
        bool Update(Assistant assistant);
        bool Delete(int assistantId);
        // Note: No ExistsByUniqueField method needed here, as there's no UNIQUE constraint other than ID
        int GetAvailableAssistantsCount(); // For dashboard overview
    }
}
