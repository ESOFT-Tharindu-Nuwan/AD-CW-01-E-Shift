﻿using EShift.Business.Interface;
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
        private readonly IUserRepository _userRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
            _userRepository = new UserRepository();
        }

        public void SaveCustomer(Customer customer)
        {
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

        public Customer GetCustomerById(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public int GetTotalCustomersCount()
        {
            return _customerRepository.GetTotalCustomersCount();
        }

    }
}
