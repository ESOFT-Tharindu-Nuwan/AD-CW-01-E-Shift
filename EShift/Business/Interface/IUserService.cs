using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface IUserService
    {
        // Business operation: Register a new customer, which also creates a user account
        bool RegisterCustomer(string username, string password, Customer customerDetails);

        // Business operation: Authenticate a user by username and password
        User AuthenticateUser(string username, string password);

        // Utility to get user by username (could be private in implementation, but useful for checks)
        User GetUserByUsername(string username);

        List<User> GetAllUsers();
    }
}
