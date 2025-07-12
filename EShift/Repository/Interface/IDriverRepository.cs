using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface IDriverRepository
    {
        List<Driver> GetAll();
        Driver GetById(int driverId);
        int Add(Driver driver); // Returns the new DriverID
        bool Update(Driver driver);
        bool Delete(int driverId);
        bool ExistsByLicenseNumber(string licenseNumber, int? excludeDriverId = null); // For unique check
        int GetAvailableDriversCount(); // For dashboard overview
    }
}
