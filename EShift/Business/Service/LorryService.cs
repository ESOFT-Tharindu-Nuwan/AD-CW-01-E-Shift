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
    public class LorryService : ILorryService
    {
        private readonly ILorryRepository _lorryRepository;

        public LorryService()
        {
            _lorryRepository = new LorryRepository();
        }

        public List<Lorry> GetAllLorries()
        {
            return _lorryRepository.GetAll();
        }

        public Lorry GetLorryById(int lorryId)
        {
            return _lorryRepository.GetById(lorryId);
        }

        public bool AddLorry(Lorry lorry)
        {
            // Business rule: Registration Number must be unique
            if (_lorryRepository.ExistsByRegistrationNumber(lorry.RegistrationNumber))
            {
                throw new InvalidOperationException($"Lorry with registration number '{lorry.RegistrationNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(lorry.RegistrationNumber))
            {
                throw new ArgumentException("Registration Number is required.");
            }

            int newId = _lorryRepository.Add(lorry);
            return newId > 0;
        }

        public bool UpdateLorry(Lorry lorry)
        {
            // Business rule: Registration Number must be unique (excluding current lorry)
            if (_lorryRepository.ExistsByRegistrationNumber(lorry.RegistrationNumber, lorry.LorryID))
            {
                throw new InvalidOperationException($"Lorry with registration number '{lorry.RegistrationNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(lorry.RegistrationNumber))
            {
                throw new ArgumentException("Registration Number is required.");
            }

            return _lorryRepository.Update(lorry);
        }

        public bool DeleteLorry(int lorryId)
        {
            // Business rule: Check if lorry is currently assigned to any active jobs/transport units
            // (You'll need to implement this check in JobRepository or TransportUnitRepository later)
            // if (_jobRepository.IsLorryAssigned(lorryId)) { throw new InvalidOperationException("Cannot delete lorry as it is currently assigned to a job."); }
            return _lorryRepository.Delete(lorryId);
        }

        public int GetAvailableLorriesCount()
        {
            return _lorryRepository.GetAvailableLorriesCount();
        }
    }
}
