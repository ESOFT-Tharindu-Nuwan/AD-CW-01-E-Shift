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

        // Constructor Injection: Dependencies are passed in via the constructor.
        // This is a good practice for testability and managing dependencies.
        public UserService()
        {
            _userRepository = new UserRepository(); // Instantiate concrete repository
            _customerRepository = new CustomerRepository(); // Instantiate concrete repository
        }

        // --- Customer Registration Logic ---
        public bool RegisterCustomer(string username, string password, Customer customerDetails)
        {
            // 1. Basic Validation (add more robust validation as needed)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password cannot be empty.");
            }
            if (password.Length < 6) // Example: enforce minimum password length
            {
                throw new ArgumentException("Password must be at least 6 characters long.");
            }
            if (string.IsNullOrWhiteSpace(customerDetails.Email) || string.IsNullOrWhiteSpace(customerDetails.FirstName))
            {
                throw new ArgumentException("Customer email and first name are required.");
            }

            // 2. Check for existing username or email
            if (_userRepository.GetUserByUsername(username) != null)
            {
                throw new InvalidOperationException("Username already exists. Please choose a different one.");
            }
            if (_customerRepository.GetCustomerByEmail(customerDetails.Email) != null)
            {
                throw new InvalidOperationException("Email address is already registered to another customer.");
            }

            // Start a transaction scope here in a more advanced scenario
            // For simplicity, we'll do sequential operations and basic rollback if one fails.
            int newUserId = 0;
            try
            {
                // 3. Hash the password
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                // 4. Create User record
                User newUser = new User
                {
                    Username = username,
                    PasswordHash = hashedPassword,
                    UserRole = "Customer", // Assign "Customer" role by default
                    IsActive = true, // New accounts are active by default
                    DateCreated = DateTime.Now
                };

                newUserId = _userRepository.AddUser(newUser);

                if (newUserId <= 0)
                {
                    // User not added (shouldn't happen with SCOPE_IDENTITY if no DB error)
                    return false;
                }

                // 5. Create Customer record, linking to the new UserID
                customerDetails.UserID = newUserId; // Link customer to the newly created user
                customerDetails.RegistrationDate = DateTime.Now;
                // Generate a unique customer number (e.g., using a prefix + UserID)
                // You can implement more sophisticated numbering (e.g., sequence, GUID)
                customerDetails.CustomerNumber = "CUST-" + newUserId.ToString("D5"); // D5 pads with leading zeros if less than 5 digits

                int newCustomerId = _customerRepository.AddCustomer(customerDetails);

                if (newCustomerId > 0)
                {
                    // All successful
                    // Optional: Add a notification for admins about new customer registration
                    // Consider creating a NotificationService in Business.Service
                    return true;
                }
                else
                {
                    // Customer not added, attempt to roll back user creation
                    _userRepository.DeleteUser(newUserId);
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log the exception (e.g., to a file or logging service)
                Console.WriteLine($"Error during customer registration: {ex.Message}");
                // If user was partially created, attempt rollback
                if (newUserId > 0)
                {
                    _userRepository.DeleteUser(newUserId);
                }
                throw; // Re-throw to inform the UI layer
            }
        }

        // --- User Authentication Logic ---
        public User AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null; // Or throw ArgumentException
            }

            // 1. Retrieve user by username from the database
            User user = _userRepository.GetUserByUsername(username);

            // 2. Check if user exists and if account is active
            if (user == null || !user.IsActive)
            {
                return null; // User not found or account is inactive
            }

            // 3. Verify the provided password against the stored hash
            // BCrypt.Net.BCrypt.Verify compares the plain password with the hash
            if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return user; // Authentication successful
            }
            else
            {
                return null; // Authentication failed (password mismatch)
            }
        }

        public User GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }
    }
}
