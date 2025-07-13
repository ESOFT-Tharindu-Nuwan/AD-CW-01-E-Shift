using EShift.DataAccess;
using EShift.Models;
using EShift.Repository.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Service
{
    public class CustomerRepository : ICustomerRepository
    {
        private Customer MapCustomerFromReader(SqlDataReader reader)
        {
            return new Customer
            {
                CustomerID = (int)reader["CustomerID"],
                UserID = reader["UserID"] == DBNull.Value ? (int?)null : (int)reader["UserID"],
                CustomerNumber = reader["CustomerNumber"].ToString(), // Assuming it's never DBNull in DB or handled by default
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                AddressLine1 = reader["AddressLine1"] == DBNull.Value ? null : reader["AddressLine1"].ToString(),
                AddressLine2 = reader["AddressLine2"] == DBNull.Value ? null : reader["AddressLine2"].ToString(),
                City = reader["City"] == DBNull.Value ? null : reader["City"].ToString(),
                Province = reader["Province"] == DBNull.Value ? null : reader["Province"].ToString(),
                PostalCode = reader["PostalCode"] == DBNull.Value ? null : reader["PostalCode"].ToString(),
                PhoneNumber = reader["PhoneNumber"] == DBNull.Value ? null : reader["PhoneNumber"].ToString(),
                Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString(),
                RegistrationDate = (DateTime)reader["RegistrationDate"]
            };
        }
        public int AddCustomer(Customer customer)
        {
            string query = "INSERT INTO Customers (UserID, CustomerNumber, FirstName, LastName, AddressLine1, AddressLine2, City, Province, PostalCode, PhoneNumber, Email, RegistrationDate) " +
                           "VALUES (@UserID, @CustomerNumber, @FirstName, @LastName, @AddressLine1, @AddressLine2, @City, @Province, @PostalCode, @PhoneNumber, @Email, @RegistrationDate); " +
                           "SELECT SCOPE_IDENTITY();";
            int newCustomerId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", customer.UserID);
                command.Parameters.AddWithValue("@CustomerNumber", customer.CustomerNumber);
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@AddressLine1", customer.AddressLine1 ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AddressLine2", customer.AddressLine2 ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@City", customer.City ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Province", customer.Province ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PostalCode", customer.PostalCode ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@RegistrationDate", customer.RegistrationDate);
                connection.Open();
                newCustomerId = Convert.ToInt32(command.ExecuteScalar());
            }
            return newCustomerId;
        }

        public Customer GetCustomerByEmail(string email)
        {
            Customer customer = null;
            string query = "SELECT CustomerID, UserID, CustomerNumber, FirstName, LastName, Email FROM Customers WHERE Email = @Email";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        CustomerID = (int)reader["CustomerID"],
                        UserID = (int)reader["UserID"],
                        CustomerNumber = reader["CustomerNumber"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }
                reader.Close();
            }
            return customer;
        }

        public Customer GetCustomerByUserID(int userId)
        {
            Customer customer = null;
            string query = "SELECT CustomerID, UserID, CustomerNumber, FirstName, LastName, AddressLine1, AddressLine2, City, Province, PostalCode, PhoneNumber, Email, RegistrationDate FROM Customers WHERE UserID = @UserID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    customer = new Customer
                    {
                        CustomerID = (int)reader["CustomerID"],
                        UserID = (int)reader["UserID"],
                        CustomerNumber = reader["CustomerNumber"].ToString(),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        AddressLine1 = reader["AddressLine1"] as string,
                        AddressLine2 = reader["AddressLine2"] as string,
                        City = reader["City"] as string,
                        Province = reader["Province"] as string,
                        PostalCode = reader["PostalCode"] as string,
                        PhoneNumber = reader["PhoneNumber"] as string,
                        Email = reader["Email"].ToString(),
                        RegistrationDate = (DateTime)reader["RegistrationDate"]
                    };
                }
                reader.Close();
            }
            return customer;
        }

        public void UpdateCustomer(Customer customer)
        {
            string query = @"
                UPDATE Customers SET
                    FirstName = @FirstName,
                    LastName = @LastName,
                    AddressLine1 = @AddressLine1,
                    AddressLine2 = @AddressLine2,
                    City = @City,
                    Province = @Province,
                    PostalCode = @PostalCode,
                    PhoneNumber = @PhoneNumber,
                    Email = @Email
                WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", customer.FirstName);
                command.Parameters.AddWithValue("@LastName", customer.LastName);
                command.Parameters.AddWithValue("@AddressLine1", customer.AddressLine1 ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AddressLine2", customer.AddressLine2 ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@City", customer.City ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Province", customer.Province ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PostalCode", customer.PostalCode ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", customer.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Customer GetCustomerById(int customerId) // NEW: Implementation for GetCustomerById
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapCustomerFromReader(reader);
                    }
                }
            }
            return null; // Customer not found
        }

        public int GetTotalCustomersCount()
        {
            string query = "SELECT COUNT(*) FROM Customers";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customers";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(MapCustomerFromReader(reader));
                    }
                }
            }
            return customers;
        }
    }
}
