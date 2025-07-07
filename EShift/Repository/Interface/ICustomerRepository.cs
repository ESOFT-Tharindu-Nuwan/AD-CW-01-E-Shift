using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface ICustomerRepository
    {
        // Add a new customer to the database, returning the new CustomerID
        int AddCustomer(Customer customer);

        // Retrieve a customer by their email address
        Customer GetCustomerByEmail(string email);

        // Retrieve a customer by their associated UserID
        Customer GetCustomerByUserID(int userId);

        // (Optional) Update an existing customer
        void UpdateCustomer(Customer customer);
    }
}
