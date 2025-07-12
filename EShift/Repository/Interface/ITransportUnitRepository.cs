using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface ITransportUnitRepository
    {
        List<TransportUnit> GetAll(); // This will need to join to get names
        TransportUnit GetById(int transportUnitId); // This will need to join
        int Add(TransportUnit unit);
        bool Update(TransportUnit unit);
        bool Delete(int transportUnitId);
        bool ExistsByUnitName(string unitName, int? excludeUnitId = null);
        List<TransportUnit> GetAvailableTransportUnits(); // For job assignment
    }
}
