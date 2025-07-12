using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IContainerService
    {
        List<Container> GetAllContainers();
        Container GetContainerById(int containerId);
        bool AddContainer(Container container);
        bool UpdateContainer(Container container);
        bool DeleteContainer(int containerId);
        int GetAvailableContainersCount();
    }
}
