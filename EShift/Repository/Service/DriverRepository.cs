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
    public class DriverRepository : IDriverRepository
    {
        private Driver MapDriverFromReader(SqlDataReader reader)
        {
            return new Driver
            {
                DriverID = (int)reader["DriverID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                LicenseNumber = reader["LicenseNumber"].ToString(),
                PhoneNumber = reader["PhoneNumber"] as string, // Handle nullable string
                Email = reader["Email"] as string,             // Handle nullable string
                Address = reader["Address"] as string,         // Handle nullable string
                IsAvailable = (bool)reader["IsAvailable"]
            };
        }

        public List<Driver> GetAll()
        {
            List<Driver> drivers = new List<Driver>();
            string query = "SELECT * FROM Drivers ORDER BY LastName, FirstName";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        drivers.Add(MapDriverFromReader(reader));
                    }
                }
            }
            return drivers;
        }

        public Driver GetById(int driverId)
        {
            string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", driverId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapDriverFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Add(Driver driver)
        {
            string query = @"
                INSERT INTO Drivers (FirstName, LastName, LicenseNumber, PhoneNumber, Email, Address, IsAvailable)
                OUTPUT INSERTED.DriverID
                VALUES (@FirstName, @LastName, @LicenseNumber, @PhoneNumber, @Email, @Address, @IsAvailable);";
            int newDriverId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", driver.FirstName);
                command.Parameters.AddWithValue("@LastName", driver.LastName);
                command.Parameters.AddWithValue("@LicenseNumber", driver.LicenseNumber);
                command.Parameters.AddWithValue("@PhoneNumber", driver.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", driver.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", driver.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsAvailable", driver.IsAvailable);

                connection.Open();
                newDriverId = (int)command.ExecuteScalar();
            }
            return newDriverId;
        }

        public bool Update(Driver driver)
        {
            string query = @"
                UPDATE Drivers SET
                    FirstName = @FirstName,
                    LastName = @LastName,
                    LicenseNumber = @LicenseNumber,
                    PhoneNumber = @PhoneNumber,
                    Email = @Email,
                    Address = @Address,
                    IsAvailable = @IsAvailable
                WHERE DriverID = @DriverID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", driver.DriverID);
                command.Parameters.AddWithValue("@FirstName", driver.FirstName);
                command.Parameters.AddWithValue("@LastName", driver.LastName);
                command.Parameters.AddWithValue("@LicenseNumber", driver.LicenseNumber);
                command.Parameters.AddWithValue("@PhoneNumber", driver.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", driver.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", driver.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsAvailable", driver.IsAvailable);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int driverId)
        {
            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverID", driverId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ExistsByLicenseNumber(string licenseNumber, int? excludeDriverId = null)
        {
            string query = "SELECT COUNT(1) FROM Drivers WHERE LicenseNumber = @LicenseNumber";
            if (excludeDriverId.HasValue)
            {
                query += " AND DriverID != @ExcludeDriverId";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicenseNumber", licenseNumber);
                if (excludeDriverId.HasValue)
                {
                    command.Parameters.AddWithValue("@ExcludeDriverId", excludeDriverId.Value);
                }
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        public int GetAvailableDriversCount()
        {
            string query = "SELECT COUNT(*) FROM Drivers WHERE IsAvailable = 1";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
