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

        // (Optional) Add a method to get customer by UserID if needed later
        Customer GetCustomerByUserID(int userId);
    }
}
