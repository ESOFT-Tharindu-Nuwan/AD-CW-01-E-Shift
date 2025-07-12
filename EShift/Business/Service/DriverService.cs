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
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService()
        {
            _driverRepository = new DriverRepository();
        }

        public List<Driver> GetAllDrivers()
        {
            return _driverRepository.GetAll();
        }

        public Driver GetDriverById(int driverId)
        {
            return _driverRepository.GetById(driverId);
        }

        public bool AddDriver(Driver driver)
        {
            // Business rule: License Number must be unique
            if (_driverRepository.ExistsByLicenseNumber(driver.LicenseNumber))
            {
                throw new InvalidOperationException($"Driver with license number '{driver.LicenseNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(driver.FirstName) || string.IsNullOrWhiteSpace(driver.LastName) || string.IsNullOrWhiteSpace(driver.LicenseNumber))
            {
                throw new ArgumentException("First Name, Last Name, and License Number are required.");
            }

            int newId = _driverRepository.Add(driver);
            return newId > 0;
        }

        public bool UpdateDriver(Driver driver)
        {
            // Business rule: License Number must be unique (excluding current driver)
            if (_driverRepository.ExistsByLicenseNumber(driver.LicenseNumber, driver.DriverID))
            {
                throw new InvalidOperationException($"Driver with license number '{driver.LicenseNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(driver.FirstName) || string.IsNullOrWhiteSpace(driver.LastName) || string.IsNullOrWhiteSpace(driver.LicenseNumber))
            {
                throw new ArgumentException("First Name, Last Name, and License Number are required.");
            }

            return _driverRepository.Update(driver);
        }

        public bool DeleteDriver(int driverId)
        {
            // Business rule: Check if driver is currently assigned to any active jobs/transport units
            // You'll need to implement this check in TransportUnitRepository or JobRepository later
            // For example: if (_transportUnitRepository.IsDriverAssigned(driverId)) { throw new InvalidOperationException("Cannot delete driver as they are currently assigned to a transport unit."); }
            return _driverRepository.Delete(driverId);
        }

        public int GetAvailableDriversCount()
        {
            return _driverRepository.GetAvailableDriversCount();
        }
    }
}
