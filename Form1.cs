using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisasterManagementSystem
{
    public partial class Form1 : Form
    {
        private SafeAreaContext safeAreaContext;
        private ResourceFactory resourceFactory;
        private NotificationManager notificationManager;

        public Form1()
        {
            InitializeComponent();
            resourceFactory = new ResourceFactory();
            notificationManager = NotificationManager.Instance;
            safeAreaContext = new SafeAreaContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate Disaster Type ComboBox
            DisasterTypeComboBox.Items.AddRange(new string[] { "Flood", "Earthquake", "Hurricane", "Tornado" });

            // Set default selections (optional)
            DisasterTypeComboBox.SelectedIndex = -1; // No item selected initially
            AreaComboBox.SelectedIndex = -1;        // No item selected initially

            // Disable buttons until a disaster type is selected
            SuggestSafeAreaButton.Enabled = false;
            ShareResourcesButton.Enabled = false;
            SendNotificationsButton.Enabled = false;
        }

        private void DisasterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate areas and enable buttons when a disaster type is selected
            AreaComboBox.Items.Clear();
            AreaComboBox.Items.AddRange(new string[] { "Saddar", "Malir", "Korangi", "Airport", "Liaquatabad", "DHA", "Nazimabad", "PECHS" });

            SuggestSafeAreaButton.Enabled = true;
            ShareResourcesButton.Enabled = true;
            SendNotificationsButton.Enabled = true;

            // Set the appropriate strategy dynamically based on selected disaster type
            string disasterType = DisasterTypeComboBox.SelectedItem?.ToString();
            if (disasterType == "Flood")
            {
                safeAreaContext.SetStrategy(new FloodSafeAreaStrategy());
            }
            else if (disasterType == "Earthquake")
            {
                safeAreaContext.SetStrategy(new EarthquakeSafeAreaStrategy());
            }
            else if (disasterType == "Hurricane")
            {
                safeAreaContext.SetStrategy(new HurricaneSafeAreaStrategy());
            }
            else if (disasterType == "Tornado")
            {
                safeAreaContext.SetStrategy(new TornadoSafeAreaStrategy());
            }

        }

        private void SuggestSafeAreaButton_Click(object sender, EventArgs e)
        {

            string affectedArea = AreaComboBox.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(affectedArea))
            {
                SafeAreaForm safeAreaForm = new SafeAreaForm();
                AffectedAreaChanged += safeAreaForm.UpdateSafeAreas; // Subscribe SafeAreaForm to the event
                safeAreaForm.UpdateSafeAreas(affectedArea); // Pass initial affected area to the SafeAreaForm
                safeAreaForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an affected area.", "Error");
            }
        }

        private void ShareResourcesButton_Click(object sender, EventArgs e)
        {
            ResourcesForm resfrm = new ResourcesForm();
            resfrm.Show();

            //string disasterType = DisasterTypeComboBox.SelectedItem?.ToString();
            //if (!string.IsNullOrEmpty(disasterType))
            //{
            //    var resources = resourceFactory.GetResources(disasterType);
            //    MessageBox.Show($"Resources for {disasterType}: {string.Join(", ", resources)}", "Resources Shared");
            //}
            //else
            //{
            //    MessageBox.Show("Please select a disaster type.", "Error");
            //}
        }

        private void SendNotificationsButton_Click(object sender, EventArgs e)
        {
            NotificationsForm notfrm = new NotificationsForm();
            notfrm.Show();  

            //ProxyNotificationSender proxy = new ProxyNotificationSender(notificationManager);
            //proxy.SendNotifications();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public delegate void AffectedAreaChangedHandler(string affectedArea);
        public event AffectedAreaChangedHandler AffectedAreaChanged;
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string affectedArea = AreaComboBox.SelectedItem?.ToString();
            AffectedAreaChanged?.Invoke(affectedArea); // Notify listeners about the change
        }

        private void AreaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
