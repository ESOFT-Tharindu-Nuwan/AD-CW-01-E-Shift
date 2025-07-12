using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IDriverService
    {
        List<Driver> GetAllDrivers();
        Driver GetDriverById(int driverId);
        bool AddDriver(Driver driver);
        bool UpdateDriver(Driver driver);
        bool DeleteDriver(int driverId);
        int GetAvailableDriversCount();
    }
}
