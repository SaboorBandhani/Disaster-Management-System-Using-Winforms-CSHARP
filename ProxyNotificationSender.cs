using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    public class ProxyNotificationSender
    {
        private readonly NotificationManager notificationManager;

        public ProxyNotificationSender(NotificationManager notificationManager)
        {
            this.notificationManager = notificationManager;

            // Attach observers
            this.notificationManager.Attach(new AmbulanceObserver());
            this.notificationManager.Attach(new MediaObserver());
        }

        public void SendNotifications()
        {
            notificationManager.Notify();
        }
    }
}
