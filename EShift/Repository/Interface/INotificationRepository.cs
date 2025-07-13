using EShift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShift.Repository.Interface
{
    public interface INotificationRepository
    {
        int Add(Notification notification);
        List<Notification> GetUnreadNotificationsByUserId(int userId);
        bool MarkAsRead(int notificationId);
    }
}
