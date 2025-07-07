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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void SaveCustomer(Customer customer)
        {
            // Here you would implement logic for updating an existing customer.
            // For initial registration, this is handled by UserService.RegisterCustomer.
            if (customer.CustomerID > 0)
            {
                _customerRepository.UpdateCustomer(customer);
            }
            else
            {
                throw new InvalidOperationException("Cannot save customer without an existing ID. Use RegisterCustomer for new customers.");
            }
        }

        public Customer GetCustomerByUserID(int userId)
        {
            return _customerRepository.GetCustomerByUserID(userId);
        }
    }
}
