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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICustomerRepository _customerRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
            _customerRepository = new CustomerRepository();
        }

        public bool RegisterCustomer(string username, string password, Customer customerDetails)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            if (password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.");
            }
            if (string.IsNullOrWhiteSpace(customerDetails.Email) || string.IsNullOrWhiteSpace(customerDetails.FirstName))
            {
                throw new ArgumentException("Customer email and first name are required.");
            }

            if (_userRepository.GetUserByUsername(username) != null)
            {
                throw new InvalidOperationException("Username already exists. Please choose a different one.");
            }
            if (_customerRepository.GetCustomerByEmail(customerDetails.Email) != null)
            {
                throw new InvalidOperationException("Email address is already registered to another customer.");
            }

            int newUserId = 0;
            try
            {

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                User newUser = new User
                {
                    Username = username,
                    PasswordHash = hashedPassword,
                    UserRole = "Customer",
                    IsActive = true,
                    DateCreated = DateTime.Now
                };

                newUserId = _userRepository.AddUser(newUser);

                if (newUserId <= 0)
                {
                    return false;
                }

                customerDetails.UserID = newUserId;
                customerDetails.RegistrationDate = DateTime.Now;

                customerDetails.CustomerNumber = "CUST-" + newUserId.ToString("D5");

                int newCustomerId = _customerRepository.AddCustomer(customerDetails);

                if (newCustomerId > 0)
                {
                    // All successful
                    // TODO: Add a notification for admins about new customer registration
                    // Consider creating a NotificationService in Business.Service
                    return true;
                }
                else
                {
                    _userRepository.DeleteUser(newUserId);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during customer registration: {ex.Message}");
                if (newUserId > 0)
                {
                    _userRepository.DeleteUser(newUserId);
                }
                throw;
            }
        }

        public User AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            User user = _userRepository.GetUserByUsername(username);

            if (user == null || !user.IsActive)
            {
                return null;
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public User GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }
    }
}
