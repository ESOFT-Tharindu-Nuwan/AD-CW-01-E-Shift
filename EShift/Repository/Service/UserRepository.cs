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
    public class UserRepository : IUserRepository
    {
        public int AddUser(User user)
        {
            string query = "INSERT INTO Users (Username, PasswordHash, UserRole, IsActive, DateCreated) " +
                           "VALUES (@Username, @PasswordHash, @UserRole, @IsActive, @DateCreated); " +
                           "SELECT SCOPE_IDENTITY();"; // Returns the ID of the newly inserted row
            int newUserId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                command.Parameters.AddWithValue("@UserRole", user.UserRole);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);
                command.Parameters.AddWithValue("@DateCreated", user.DateCreated);
                connection.Open();
                newUserId = Convert.ToInt32(command.ExecuteScalar());
            }
            return newUserId;
        }

        public User GetUserByUsername(string username)
        {
            User user = null;
            string query = "SELECT UserID, Username, PasswordHash, UserRole, IsActive, DateCreated FROM Users WHERE Username = @Username";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user = new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        PasswordHash = reader["PasswordHash"].ToString(),
                        UserRole = reader["UserRole"].ToString(),
                        IsActive = (bool)reader["IsActive"],
                        DateCreated = (DateTime)reader["DateCreated"]
                    };
                }
                reader.Close();
            }
            return user;
        }

        public void DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
