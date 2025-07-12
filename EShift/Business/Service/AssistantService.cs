using EShift.Business.Interface;
using EShift.Models;
using EShift.Repository.Interface;
using EShift.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Service
{
    public class AssistantService : IAssistantService
    {
        private readonly IAssistantRepository _assistantRepository;

        public AssistantService()
        {
            _assistantRepository = new AssistantRepository();
        }

        public List<Assistant> GetAllAssistants()
        {
            return _assistantRepository.GetAll();
        }

        public Assistant GetAssistantById(int assistantId)
        {
            return _assistantRepository.GetById(assistantId);
        }

        public bool AddAssistant(Assistant assistant)
        {
            // Basic validation: First Name and Last Name are required.
            if (string.IsNullOrWhiteSpace(assistant.FirstName) || string.IsNullOrWhiteSpace(assistant.LastName))
            {
                throw new ArgumentException("First Name and Last Name are required for an assistant.");
            }
            // No unique field (like LicenseNumber for Drivers) to check for existence here.

            int newId = _assistantRepository.Add(assistant);
            return newId > 0;
        }

        public bool UpdateAssistant(Assistant assistant)
        {
            // Basic validation: First Name and Last Name are required.
            if (string.IsNullOrWhiteSpace(assistant.FirstName) || string.IsNullOrWhiteSpace(assistant.LastName))
            {
                throw new ArgumentException("First Name and Last Name are required for an assistant.");
            }
            return _assistantRepository.Update(assistant);
        }

        public bool DeleteAssistant(int assistantId)
        {
            // Business rule: Check if assistant is currently assigned to any active transport units
            // You'll need to implement this check in TransportUnitRepository later
            // For example: if (_transportUnitRepository.IsAssistantAssigned(assistantId)) { throw new InvalidOperationException("Cannot delete assistant as they are currently assigned to a transport unit."); }
            return _assistantRepository.Delete(assistantId);
        }

        public int GetAvailableAssistantsCount()
        {
            return _assistantRepository.GetAvailableAssistantsCount();
        }
    }
}
