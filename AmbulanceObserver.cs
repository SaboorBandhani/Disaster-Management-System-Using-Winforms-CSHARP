using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisasterManagementSystem
{
    public class AmbulanceObserver : IObserver
    {
        public void Update()
        {
            MessageBox.Show("Notification sent to Ambulance Services.", "Notification");
        }
    }
}
