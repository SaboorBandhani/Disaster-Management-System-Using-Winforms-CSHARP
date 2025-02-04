using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    public class NotificationManager
    {
        private static NotificationManager instance;
        private readonly List<IObserver> observers;

        private NotificationManager()
        {
            observers = new List<IObserver>();  // Initialize the list here
        }
        public static NotificationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotificationManager();
                }
                return instance;
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
