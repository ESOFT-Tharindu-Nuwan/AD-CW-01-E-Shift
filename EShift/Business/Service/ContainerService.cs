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
    public class ContainerService : IContainerService
    {
        private readonly IContainerRepository _containerRepository;

        public ContainerService()
        {
            _containerRepository = new ContainerRepository();
        }

        public List<Container> GetAllContainers()
        {
            return _containerRepository.GetAll();
        }

        public Container GetContainerById(int containerId)
        {
            return _containerRepository.GetById(containerId);
        }

        public bool AddContainer(Container container)
        {
            // Business rule: Container Number must be unique
            if (_containerRepository.ExistsByContainerNumber(container.ContainerNumber))
            {
                throw new InvalidOperationException($"Container with number '{container.ContainerNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(container.ContainerNumber))
            {
                throw new ArgumentException("Container Number is required.");
            }

            int newId = _containerRepository.Add(container);
            return newId > 0;
        }

        public bool UpdateContainer(Container container)
        {
            // Business rule: Container Number must be unique (excluding current container)
            if (_containerRepository.ExistsByContainerNumber(container.ContainerNumber, container.ContainerID))
            {
                throw new InvalidOperationException($"Container with number '{container.ContainerNumber}' already exists.");
            }
            if (string.IsNullOrWhiteSpace(container.ContainerNumber))
            {
                throw new ArgumentException("Container Number is required.");
            }

            return _containerRepository.Update(container);
        }

        public bool DeleteContainer(int containerId)
        {
            // Business rule: Check if container is currently assigned to any active transport units
            // You'll need to implement this check in TransportUnitRepository later
            // For example: if (_transportUnitRepository.IsContainerAssigned(containerId)) { throw new InvalidOperationException("Cannot delete container as it is currently assigned to a transport unit."); }
            return _containerRepository.Delete(containerId);
        }

        public int GetAvailableContainersCount()
        {
            return _containerRepository.GetAvailableContainersCount();
        }
    }
}
