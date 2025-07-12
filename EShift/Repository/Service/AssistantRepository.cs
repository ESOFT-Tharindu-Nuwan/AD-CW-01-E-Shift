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
    public class AssistantRepository : IAssistantRepository
    {
        private Assistant MapAssistantFromReader(SqlDataReader reader)
        {
            return new Assistant
            {
                AssistantID = (int)reader["AssistantID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                PhoneNumber = reader["PhoneNumber"] as string, // Handle nullable string
                Email = reader["Email"] as string,             // Handle nullable string
                Address = reader["Address"] as string,         // Handle nullable string
                IsAvailable = (bool)reader["IsAvailable"]
            };
        }

        public List<Assistant> GetAll()
        {
            List<Assistant> assistants = new List<Assistant>();
            string query = "SELECT * FROM Assistants ORDER BY LastName, FirstName";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assistants.Add(MapAssistantFromReader(reader));
                    }
                }
            }
            return assistants;
        }

        public Assistant GetById(int assistantId)
        {
            string query = "SELECT * FROM Assistants WHERE AssistantID = @AssistantID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AssistantID", assistantId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapAssistantFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Add(Assistant assistant)
        {
            string query = @"
                INSERT INTO Assistants (FirstName, LastName, PhoneNumber, Email, Address, IsAvailable)
                OUTPUT INSERTED.AssistantID
                VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @IsAvailable);";
            int newAssistantId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", assistant.FirstName);
                command.Parameters.AddWithValue("@LastName", assistant.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", assistant.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", assistant.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", assistant.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsAvailable", assistant.IsAvailable);

                connection.Open();
                newAssistantId = (int)command.ExecuteScalar();
            }
            return newAssistantId;
        }

        public bool Update(Assistant assistant)
        {
            string query = @"
                UPDATE Assistants SET
                    FirstName = @FirstName,
                    LastName = @LastName,
                    PhoneNumber = @PhoneNumber,
                    Email = @Email,
                    Address = @Address,
                    IsAvailable = @IsAvailable
                WHERE AssistantID = @AssistantID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AssistantID", assistant.AssistantID);
                command.Parameters.AddWithValue("@FirstName", assistant.FirstName);
                command.Parameters.AddWithValue("@LastName", assistant.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", assistant.PhoneNumber ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Email", assistant.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Address", assistant.Address ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsAvailable", assistant.IsAvailable);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int assistantId)
        {
            string query = "DELETE FROM Assistants WHERE AssistantID = @AssistantID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AssistantID", assistantId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public int GetAvailableAssistantsCount()
        {
            string query = "SELECT COUNT(*) FROM Assistants WHERE IsAvailable = 1";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
