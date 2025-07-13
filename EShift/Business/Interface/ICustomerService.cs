using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface ICustomerService
    {
        // For saving/updating existing customer details
        void SaveCustomer(Customer customer);

        Customer GetCustomerByUserID(int userId);

        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        int GetTotalCustomersCount();
    }
}
