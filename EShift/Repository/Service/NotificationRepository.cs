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
    public class NotificationRepository : INotificationRepository
    {
        private Notification MapNotificationFromReader(SqlDataReader reader)
        {
            return new Notification
            {
                NotificationID = (int)reader["NotificationID"],
                UserID = (int)reader["UserID"],
                MessageType = reader["MessageType"].ToString(),
                MessageContent = reader["MessageContent"].ToString(),
                RelatedEntityID = reader["RelatedEntityID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["RelatedEntityID"]),
                RelatedEntityType = reader["RelatedEntityType"] as string,
                IsRead = (bool)reader["IsRead"],
                Timestamp = (DateTime)reader["Timestamp"]
            };
        }

        public int Add(Notification notification)
        {
            string query = @"
                INSERT INTO Notifications (UserID, MessageType, MessageContent, RelatedEntityID, RelatedEntityType, IsRead, Timestamp)
                OUTPUT INSERTED.NotificationID
                VALUES (@UserID, @MessageType, @MessageContent, @RelatedEntityID, @RelatedEntityType, @IsRead, @Timestamp);";
            int newNotificationId = 0;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", notification.UserID);
                command.Parameters.AddWithValue("@MessageType", notification.MessageType);
                command.Parameters.AddWithValue("@MessageContent", notification.MessageContent);
                command.Parameters.AddWithValue("@RelatedEntityID", notification.RelatedEntityID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@RelatedEntityType", notification.RelatedEntityType ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@IsRead", notification.IsRead);
                command.Parameters.AddWithValue("@Timestamp", notification.Timestamp);

                connection.Open();
                newNotificationId = Convert.ToInt32(command.ExecuteScalar());
            }
            return newNotificationId;
        }

        public List<Notification> GetUnreadNotificationsByUserId(int userId)
        {
            List<Notification> notifications = new List<Notification>();
            string query = "SELECT * FROM Notifications WHERE UserID = @UserID AND IsRead = 0 ORDER BY Timestamp DESC";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        notifications.Add(MapNotificationFromReader(reader));
                    }
                }
            }
            return notifications;
        }

        public bool MarkAsRead(int notificationId)
        {
            string query = "UPDATE Notifications SET IsRead = 1 WHERE NotificationID = @NotificationID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NotificationID", notificationId);
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
