using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface IContainerRepository
    {
        List<Container> GetAll();
        Container GetById(int containerId);
        int Add(Container container); // Returns the new ContainerID
        bool Update(Container container);
        bool Delete(int containerId);
        bool ExistsByContainerNumber(string containerNumber, int? excludeContainerId = null); // For unique check
        int GetAvailableContainersCount(); // For dashboard overview
    }
}
