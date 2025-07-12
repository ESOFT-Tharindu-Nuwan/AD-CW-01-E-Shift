using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IAssistantService
    {
        List<Assistant> GetAllAssistants();
        Assistant GetAssistantById(int assistantId);
        bool AddAssistant(Assistant assistant);
        bool UpdateAssistant(Assistant assistant);
        bool DeleteAssistant(int assistantId);
        int GetAvailableAssistantsCount();
    }
}
