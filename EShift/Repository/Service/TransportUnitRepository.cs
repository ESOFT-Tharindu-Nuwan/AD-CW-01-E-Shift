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
    public class TransportUnitRepository : ITransportUnitRepository
    {
        private TransportUnit MapTransportUnitFromReader(SqlDataReader reader)
        {
            return new TransportUnit
            {
                TransportUnitID = (int)reader["TransportUnitID"],
                LorryID = (int)reader["LorryID"],
                DriverID = (int)reader["DriverID"],
                AssistantID = reader["AssistantID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["AssistantID"]),
                ContainerID = reader["ContainerID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["ContainerID"]),
                UnitName = reader["UnitName"].ToString(),
                IsOperational = (bool)reader["IsOperational"],
                // Populate display properties from joins
                LorryRegistrationNumber = reader["LorryRegistrationNumber"] as string,
                DriverName = reader["DriverFullName"] as string,
                AssistantName = reader["AssistantFullName"] == DBNull.Value ? null : reader["AssistantFullName"] as string,
                ContainerNumber = reader["ContainerNumber"] == DBNull.Value ? null : reader["ContainerNumber"] as string
            };
        }

        public List<TransportUnit> GetAll()
        {
            List<TransportUnit> units = new List<TransportUnit>();
            string query = @"
                SELECT tu.*,
                       l.RegistrationNumber AS LorryRegistrationNumber,
                       d.FirstName + ' ' + d.LastName AS DriverFullName,
                       a.FirstName + ' ' + a.LastName AS AssistantFullName,
                       c.ContainerNumber AS ContainerNumber
                FROM TransportUnits tu
                JOIN Lorries l ON tu.LorryID = l.LorryID
                JOIN Drivers d ON tu.DriverID = d.DriverID
                LEFT JOIN Assistants a ON tu.AssistantID = a.AssistantID
                LEFT JOIN Containers c ON tu.ContainerID = c.ContainerID
                ORDER BY tu.UnitName;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        units.Add(MapTransportUnitFromReader(reader));
                    }
                }
            }
            return units;
        }

        public TransportUnit GetById(int transportUnitId)
        {
            string query = @"
                SELECT tu.*,
                       l.RegistrationNumber AS LorryRegistrationNumber,
                       d.FirstName + ' ' + d.LastName AS DriverFullName,
                       a.FirstName + ' ' + a.LastName AS AssistantFullName,
                       c.ContainerNumber AS ContainerNumber
                FROM TransportUnits tu
                JOIN Lorries l ON tu.LorryID = l.LorryID
                JOIN Drivers d ON tu.DriverID = d.DriverID
                LEFT JOIN Assistants a ON tu.AssistantID = a.AssistantID
                LEFT JOIN Containers c ON tu.ContainerID = c.ContainerID
                WHERE tu.TransportUnitID = @TransportUnitID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapTransportUnitFromReader(reader);
                    }
                }
            }
            return null;
        }

        public int Add(TransportUnit unit)
        {
            string query = @"
                INSERT INTO TransportUnits (LorryID, DriverID, AssistantID, ContainerID, UnitName, IsOperational)
                OUTPUT INSERTED.TransportUnitID
                VALUES (@LorryID, @DriverID, @AssistantID, @ContainerID, @UnitName, @IsOperational);";
            int newUnitId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LorryID", unit.LorryID);
                command.Parameters.AddWithValue("@DriverID", unit.DriverID);
                command.Parameters.AddWithValue("@AssistantID", unit.AssistantID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContainerID", unit.ContainerID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UnitName", unit.UnitName);
                command.Parameters.AddWithValue("@IsOperational", unit.IsOperational);

                connection.Open();
                newUnitId = (int)command.ExecuteScalar();
            }
            return newUnitId;
        }

        public bool Update(TransportUnit unit)
        {
            string query = @"
                UPDATE TransportUnits SET
                    LorryID = @LorryID,
                    DriverID = @DriverID,
                    AssistantID = @AssistantID,
                    ContainerID = @ContainerID,
                    UnitName = @UnitName,
                    IsOperational = @IsOperational
                WHERE TransportUnitID = @TransportUnitID;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransportUnitID", unit.TransportUnitID);
                command.Parameters.AddWithValue("@LorryID", unit.LorryID);
                command.Parameters.AddWithValue("@DriverID", unit.DriverID);
                command.Parameters.AddWithValue("@AssistantID", unit.AssistantID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContainerID", unit.ContainerID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@UnitName", unit.UnitName);
                command.Parameters.AddWithValue("@IsOperational", unit.IsOperational);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int transportUnitId)
        {
            string query = "DELETE FROM TransportUnits WHERE TransportUnitID = @TransportUnitID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool ExistsByUnitName(string unitName, int? excludeUnitId = null)
        {
            string query = "SELECT COUNT(1) FROM TransportUnits WHERE UnitName = @UnitName";
            if (excludeUnitId.HasValue)
            {
                query += " AND TransportUnitID != @ExcludeUnitId";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UnitName", unitName);
                if (excludeUnitId.HasValue)
                {
                    command.Parameters.AddWithValue("@ExcludeUnitId", excludeUnitId.Value);
                }
                connection.Open();
                return (int)command.ExecuteScalar() > 0;
            }
        }

        public List<TransportUnit> GetAvailableTransportUnits()
        {
            List<TransportUnit> units = new List<TransportUnit>();
            string query = @"
                SELECT tu.*,
                       l.RegistrationNumber AS LorryRegistrationNumber,
                       d.FirstName + ' ' + d.LastName AS DriverFullName,
                       a.FirstName + ' ' + a.LastName AS AssistantFullName,
                       c.ContainerNumber AS ContainerNumber
                FROM TransportUnits tu
                JOIN Lorries l ON tu.LorryID = l.LorryID
                JOIN Drivers d ON tu.DriverID = d.DriverID
                LEFT JOIN Assistants a ON tu.AssistantID = a.AssistantID
                LEFT JOIN Containers c ON tu.ContainerID = c.ContainerID
                WHERE tu.IsOperational = 1
                AND l.IsAvailable = 1 AND d.IsAvailable = 1
                -- Add more complex availability logic if needed (e.g., check if assigned to active job)
                ORDER BY tu.UnitName;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        units.Add(MapTransportUnitFromReader(reader));
                    }
                }
            }
            return units;
        }
    }
}
