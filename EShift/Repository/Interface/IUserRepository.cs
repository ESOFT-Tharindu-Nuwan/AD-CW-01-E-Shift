using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface IUserRepository
    {
        // Add a user to the database, returning the new UserID
        int AddUser(User user);

        // Retrieve a user from the database by username
        User GetUserByUsername(string username);

        // (Optional) Method to delete a user, useful for rollback if customer creation fails
        void DeleteUser(int userId);
    }
}
