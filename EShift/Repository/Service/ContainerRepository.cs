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
    public class ContainerRepository : IContainerRepository
    {
        private Container MapContainerFromReader(SqlDataReader reader)
        {
            return new Container
            {
                ContainerID = (int)reader["ContainerID"],
                ContainerNumber = reader["ContainerNumber"].ToString(),
                Type = reader["Type"] as string,
                CapacityCBM = (decimal)(reader["CapacityCBM"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["CapacityCBM"])),
                IsAvailable = (bool)reader["IsAvailable"]
            };
        }

        public List<Container> GetAll()
        {
            List<Container> containers = new List<Container>();
            string query = "SELECT * FROM Containers ORDER BY ContainerNumber";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        containers.Add(MapContainerFromReader(reader));
                    }
                }
            }
            return containers;
        }

        public Container GetById(int containerId)
        {
            string query = "SELECT * FROM Containers WHERE ContainerID = @ContainerID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContainerID", containerId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapContainerFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Add(Container container)
        {
            string query = @"
                INSERT INTO Containers (ContainerNumber, Type, CapacityCBM, IsAvailable)
                OUTPUT INSERTED.ContainerID
                VALUES (@ContainerNumber, @Type, @CapacityCBM, @IsAvailable);";
            int newContainerId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContainerNumber", container.ContainerNumber);
                command.Parameters.AddWithValue("@Type", container.Type ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CapacityCBM", container.CapacityCBM);
                command.Parameters.AddWithValue("@IsAvailable", container.IsAvailable);

                connection.Open();
                newContainerId = (int)command.ExecuteScalar();
            }
            return newContainerId;
        }

        public bool Update(Container container)
        {
            string query = @"
                UPDATE Containers SET
                    ContainerNumber = @ContainerNumber,
                    Type = @Type,
                    CapacityCBM = @CapacityCBM,
                    IsAvailable = @IsAvailable
                WHERE ContainerID = @ContainerID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContainerID", container.ContainerID);
                command.Parameters.AddWithValue("@ContainerNumber", container.ContainerNumber);
                command.Parameters.AddWithValue("@Type", container.Type ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CapacityCBM", container.CapacityCBM);
                command.Parameters.AddWithValue("@IsAvailable", container.IsAvailable);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int containerId)
        {
            string query = "DELETE FROM Containers WHERE ContainerID = @ContainerID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContainerID", containerId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ExistsByContainerNumber(string containerNumber, int? excludeContainerId = null)
        {
            string query = "SELECT COUNT(1) FROM Containers WHERE ContainerNumber = @ContainerNumber";
            if (excludeContainerId.HasValue)
            {
                query += " AND ContainerID != @ExcludeContainerId";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContainerNumber", containerNumber);
                if (excludeContainerId.HasValue)
                {
                    command.Parameters.AddWithValue("@ExcludeContainerId", excludeContainerId.Value);
                }
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        public int GetAvailableContainersCount()
        {
            string query = "SELECT COUNT(*) FROM Containers WHERE IsAvailable = 1";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
