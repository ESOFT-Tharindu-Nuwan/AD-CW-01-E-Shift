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
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IUserRepository _userRepository; // To find admin user ID

        public NotificationService()
        {
            _notificationRepository = new NotificationRepository();
            _userRepository = new UserRepository(); // Or inject via DI
        }

        public bool AddNotification(Notification notification)
        {
            notification.Timestamp = DateTime.Now;
            notification.IsRead = false; // Always false when adding new
            return _notificationRepository.Add(notification) > 0;
        }

        public List<Notification> GetUnreadNotificationsForUser(int userId)
        {
            return _notificationRepository.GetUnreadNotificationsByUserId(userId);
        }

        public bool MarkNotificationAsRead(int notificationId)
        {
            return _notificationRepository.MarkAsRead(notificationId);
        }

        // This is a placeholder. In a real app, you'd fetch this dynamically,
        // or have a dedicated 'Admin' user ID in configuration.
        public int GetAdminUserId()
        {
            // Find the UserID of an Admin user.
            // This assumes there's at least one user with 'Admin' role.
            // For production, consider getting a specific 'primary' admin ID or
            // querying all admin IDs and sending notifications to all of them.
            var adminUser = _userRepository.GetAll().FirstOrDefault(u => u.UserRole == "Admin");
            if (adminUser == null)
            {
                // Handle case where no admin user is found.
                // Log an error, throw an exception, or return a default/invalid ID.
                throw new InvalidOperationException("No admin user found to send notification to.");
            }
            return adminUser.UserID;
        }
    }
}
