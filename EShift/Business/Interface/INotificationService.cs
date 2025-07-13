using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Business.Interface
{
    public interface INotificationService
    {
        bool AddNotification(Notification notification);
        List<Notification> GetUnreadNotificationsForUser(int userId);
        bool MarkNotificationAsRead(int notificationId);
        int GetAdminUserId(); // Added to get the admin ID for notifications
    }
}
