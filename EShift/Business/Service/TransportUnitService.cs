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
    public class TransportUnitService : ITransportUnitService
    {
        private readonly ITransportUnitRepository _transportUnitRepository;

        public TransportUnitService()
        {
            _transportUnitRepository = new TransportUnitRepository();
        }

        public List<TransportUnit> GetAllTransportUnits()
        {
            return _transportUnitRepository.GetAll();
        }

        public TransportUnit GetTransportUnitById(int transportUnitId)
        {
            return _transportUnitRepository.GetById(transportUnitId);
        }

        public bool AddTransportUnit(TransportUnit unit)
        {
            if (string.IsNullOrWhiteSpace(unit.UnitName))
            {
                throw new ArgumentException("Unit Name is required.");
            }
            if (_transportUnitRepository.ExistsByUnitName(unit.UnitName))
            {
                throw new InvalidOperationException($"Transport Unit with name '{unit.UnitName}' already exists.");
            }
            // Add more validation: LorryID, DriverID must exist
            // (You might add methods to LorryService/DriverService to check existence)

            int newId = _transportUnitRepository.Add(unit);
            return newId > 0;
        }

        public bool UpdateTransportUnit(TransportUnit unit)
        {
            if (string.IsNullOrWhiteSpace(unit.UnitName))
            {
                throw new ArgumentException("Unit Name is required.");
            }
            if (_transportUnitRepository.ExistsByUnitName(unit.UnitName, unit.TransportUnitID))
            {
                throw new InvalidOperationException($"Transport Unit with name '{unit.UnitName}' already exists.");
            }
            // Add more validation: LorryID, DriverID must exist

            return _transportUnitRepository.Update(unit);
        }

        public bool DeleteTransportUnit(int transportUnitId)
        {
            // Business rule: Check if transport unit is currently assigned to any active jobs
            // (You'll need to implement this check in JobRepository later)
            // if (_jobRepository.IsTransportUnitAssigned(transportUnitId)) { throw new InvalidOperationException("Cannot delete transport unit as it is currently assigned to an active job."); }
            return _transportUnitRepository.Delete(transportUnitId);
        }

        public List<TransportUnit> GetAvailableTransportUnits()
        {
            return _transportUnitRepository.GetAvailableTransportUnits();
        }
    }
}
