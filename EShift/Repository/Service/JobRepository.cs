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
    public class JobRepository : IJobRepository
    {
        private Job MapJobFromReader(SqlDataReader reader)
        {
            return new Job
            {
                JobID = (int)reader["JobID"],
                JobNumber = reader["JobNumber"].ToString(),
                CustomerID = (int)reader["CustomerID"],
                RequestedDate = (DateTime)reader["RequestedDate"],
                ScheduledPickupDate = reader["ScheduledPickupDate"] as DateTime?,
                ScheduledDeliveryDate = reader["ScheduledDeliveryDate"] as DateTime?,
                ActualPickupDate = reader["ActualPickupDate"] as DateTime?,
                ActualDeliveryDate = reader["ActualDeliveryDate"] as DateTime?,
                PickupLocation = reader["PickupLocation"].ToString(),
                DeliveryLocation = reader["DeliveryLocation"].ToString(),
                JobStatus = reader["JobStatus"].ToString(),
                TransportUnitID = reader["TransportUnitID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["TransportUnitID"]),
                QuotedPrice = reader["QuotedPrice"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["QuotedPrice"]),
                FinalPrice = reader["FinalPrice"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(reader["FinalPrice"]),
                Remarks = reader["Remarks"] as string,
                AdminAssignedDate = reader["AdminAssignedDate"] as DateTime?
            };
        }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();
            string query = "SELECT * FROM Jobs ORDER BY RequestedDate DESC";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        jobs.Add(MapJobFromReader(reader));
                    }
                }
            }
            return jobs;
        }

        public Job GetById(int jobId)
        {
            string query = "SELECT * FROM Jobs WHERE JobID = @JobID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", jobId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapJobFromReader(reader);
                    }
                }
            }
            return null;
        }

        public bool Update(Job job)
        {
            string query = @"
                UPDATE Jobs SET
                    ScheduledPickupDate = @ScheduledPickupDate,
                    ScheduledDeliveryDate = @ScheduledDeliveryDate,
                    ActualPickupDate = @ActualPickupDate,
                    ActualDeliveryDate = @ActualDeliveryDate,
                    PickupLocation = @PickupLocation,
                    DeliveryLocation = @DeliveryLocation,
                    JobStatus = @JobStatus,
                    TransportUnitID = @TransportUnitID,
                    QuotedPrice = @QuotedPrice,
                    FinalPrice = @FinalPrice,
                    Remarks = @Remarks,
                    AdminAssignedDate = @AdminAssignedDate
                WHERE JobID = @JobID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JobID", job.JobID);
                command.Parameters.AddWithValue("@ScheduledPickupDate", job.ScheduledPickupDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ScheduledDeliveryDate", job.ScheduledDeliveryDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ActualPickupDate", job.ActualPickupDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ActualDeliveryDate", job.ActualDeliveryDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@PickupLocation", job.PickupLocation);
                command.Parameters.AddWithValue("@DeliveryLocation", job.DeliveryLocation);
                command.Parameters.AddWithValue("@JobStatus", job.JobStatus);
                command.Parameters.AddWithValue("@TransportUnitID", job.TransportUnitID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@QuotedPrice", job.QuotedPrice ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FinalPrice", job.FinalPrice ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Remarks", job.Remarks ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AdminAssignedDate", job.AdminAssignedDate ?? (object)DBNull.Value);

                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStatus(int jobId, string newStatus)
        {
            string query = "UPDATE Jobs SET JobStatus = @NewStatus WHERE JobID = @JobID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewStatus", newStatus);
                command.Parameters.AddWithValue("@JobID", jobId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public bool AssignTransportUnit(int jobId, int transportUnitId, DateTime adminAssignedDate)
        {
            string query = "UPDATE Jobs SET TransportUnitID = @TransportUnitID, AdminAssignedDate = @AdminAssignedDate, JobStatus = 'Scheduled' WHERE JobID = @JobID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransportUnitID", transportUnitId);
                command.Parameters.AddWithValue("@AdminAssignedDate", adminAssignedDate);
                command.Parameters.AddWithValue("@JobID", jobId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

        public int GetActiveJobsCount()
        {
            string query = "SELECT COUNT(*) FROM Jobs WHERE JobStatus IN ('Pending', 'Scheduled', 'In Progress')";
            return GetSingleIntResult(query);
        }

        public int GetPendingRequestsCount()
        {
            string query = "SELECT COUNT(*) FROM Jobs WHERE JobStatus = 'Pending'";
            return GetSingleIntResult(query);
        }

        private int GetSingleIntResult(string query)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
    }
}
