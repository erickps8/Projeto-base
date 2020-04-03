using System;
using System.Collections.Generic;
using System.Text;
using Template.Business.Notifications;

namespace Template.Business.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
