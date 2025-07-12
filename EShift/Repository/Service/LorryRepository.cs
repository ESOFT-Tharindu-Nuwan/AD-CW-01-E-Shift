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
    public class LorryRepository : ILorryRepository
    {
        private Lorry MapLorryFromReader(SqlDataReader reader)
        {
            return new Lorry
            {
                LorryID = (int)reader["LorryID"],
                RegistrationNumber = reader["RegistrationNumber"].ToString(),
                Make = reader["Make"] as string,
                Model = reader["Model"] as string,
                Capacity = (decimal)(reader["Capacity"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["Capacity"])),
                FuelType = reader["FuelType"] as string,
                CurrentMileage = (decimal)(reader["CurrentMileage"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["CurrentMileage"])),
                IsAvailable = (bool)reader["IsAvailable"]
            };
        }

        public List<Lorry> GetAll()
        {
            List<Lorry> lorries = new List<Lorry>();
            string query = "SELECT * FROM Lorries ORDER BY RegistrationNumber";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lorries.Add(MapLorryFromReader(reader));
                    }
                }
            }
            return lorries;
        }

        public Lorry GetById(int lorryId)
        {
            string query = "SELECT * FROM Lorries WHERE LorryID = @LorryID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LorryID", lorryId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapLorryFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Add(Lorry lorry)
        {
            string query = @"
                INSERT INTO Lorries (RegistrationNumber, Make, Model, Capacity, FuelType, CurrentMileage, IsAvailable)
                OUTPUT INSERTED.LorryID
                VALUES (@RegistrationNumber, @Make, @Model, @Capacity, @FuelType, @CurrentMileage, @IsAvailable);";
            int newLorryId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegistrationNumber", lorry.RegistrationNumber);
                command.Parameters.AddWithValue("@Make", lorry.Make ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Model", lorry.Model ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Capacity", lorry.Capacity);
                command.Parameters.AddWithValue("@FuelType", lorry.FuelType ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CurrentMileage", lorry.CurrentMileage);
                command.Parameters.AddWithValue("@IsAvailable", lorry.IsAvailable);

                connection.Open();
                newLorryId = (int)command.ExecuteScalar();
            }
            return newLorryId;
        }

        public bool Update(Lorry lorry)
        {
            string query = @"
                UPDATE Lorries SET
                    RegistrationNumber = @RegistrationNumber,
                    Make = @Make,
                    Model = @Model,
                    Capacity = @Capacity,
                    FuelType = @FuelType,
                    CurrentMileage = @CurrentMileage,
                    IsAvailable = @IsAvailable
                WHERE LorryID = @LorryID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LorryID", lorry.LorryID);
                command.Parameters.AddWithValue("@RegistrationNumber", lorry.RegistrationNumber);
                command.Parameters.AddWithValue("@Make", lorry.Make ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Model", lorry.Model ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Capacity", lorry.Capacity);
                command.Parameters.AddWithValue("@FuelType", lorry.FuelType ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CurrentMileage", lorry.CurrentMileage);
                command.Parameters.AddWithValue("@IsAvailable", lorry.IsAvailable);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int lorryId)
        {
            string query = "DELETE FROM Lorries WHERE LorryID = @LorryID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LorryID", lorryId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ExistsByRegistrationNumber(string registrationNumber, int? excludeLorryId = null)
        {
            string query = "SELECT COUNT(1) FROM Lorries WHERE RegistrationNumber = @RegistrationNumber";
            if (excludeLorryId.HasValue)
            {
                query += " AND LorryID != @ExcludeLorryId";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);
                if (excludeLorryId.HasValue)
                {
                    command.Parameters.AddWithValue("@ExcludeLorryId", excludeLorryId.Value);
                }
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        public int GetAvailableLorriesCount()
        {
            string query = "SELECT COUNT(*) FROM Lorries WHERE IsAvailable = 1";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
