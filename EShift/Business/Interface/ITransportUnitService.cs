using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface ITransportUnitService
    {
        List<TransportUnit> GetAllTransportUnits();
        TransportUnit GetTransportUnitById(int transportUnitId);
        bool AddTransportUnit(TransportUnit unit);
        bool UpdateTransportUnit(TransportUnit unit);
        bool DeleteTransportUnit(int transportUnitId);
        List<TransportUnit> GetAvailableTransportUnits();
    }
}
