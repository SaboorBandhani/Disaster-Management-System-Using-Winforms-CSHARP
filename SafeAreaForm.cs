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
    public partial class SafeAreaForm : Form
    {
        // Instance of SafeAreaContext to manage safe areas
        private safeAreaContext safeAreaContext;

        public SafeAreaForm()
        {
            InitializeComponent();

            // Initialize the SafeAreaContext
            safeAreaContext = new safeAreaContext();
        }

        private void SafeAreaForm_Load(object sender, EventArgs e)
        {
        }

        private void BtnMarkSafe_Click_1(object sender, EventArgs e)
        {
            string newSafeArea = Microsoft.VisualBasic.Interaction.InputBox(
    "Enter the name of the new safe area:",
    "Add Safe Area",
    "");

            // Check if a valid safe area name was provided
            if (string.IsNullOrWhiteSpace(newSafeArea))
            {
                MessageBox.Show("No safe area entered. Operation canceled.");
                return; // Exit if no valid input is provided
            }

            // Prompt the user to enter the affected area
            string affectedArea = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the affected area name:",
                "Affected Area",
                "");

            if (string.IsNullOrWhiteSpace(affectedArea))
            {
                MessageBox.Show("No affected area entered. Operation canceled.");
                return; // Exit if no valid affected area input is provided
            }

            // Add the new safe area to the context (assuming a method like AddSafeArea exists)
            safeAreaContext.AddSafeArea(affectedArea, newSafeArea);

            // Update the ListBox or any other UI component
            UpdateSafeAreas(affectedArea);

            // Notify the user that the operation was successful
            MessageBox.Show($"New safe area '{newSafeArea}' has been added to {affectedArea}.");
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            // Show details of the selected safe area
            if (lstSafeAreas.SelectedItem != null)
            {
                MessageBox.Show($"Details for {lstSafeAreas.SelectedItem}");
            }
            else
            {
                MessageBox.Show("Please select a safe area first.");
            }
        }

        public void UpdateSafeAreas(string affectedArea)
        {
            // Clear the ListBox before adding new items
            lstSafeAreas.Items.Clear();

            // Get safe areas for the selected affected area
            List<string> safeAreas = safeAreaContext.GetSafeAreas(affectedArea);

            // Populate the ListBox with safe areas
            foreach (string safeArea in safeAreas)
            {
                lstSafeAreas.Items.Add(safeArea);
            }
        }

        private void lstSafeAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtAffectedArea_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class safeAreaContext
    {
        // Dictionary to store affected areas and their safe areas
        private Dictionary<string, List<string>> data;

        public safeAreaContext()
        {
            // Initialize the data dictionary
            data = new Dictionary<string, List<string>>
            {
                { "Saddar", new List<string> { "Safe Area 1: City Park", "Safe Area 2: Community Center" } },
                { "Malir", new List<string> { "Safe Area 3: School Shelter", "Safe Area 4: Mosque Ground" } },
                { "Korangi", new List<string> { "Safe Area 5: Korangi Stadium", "Safe Area 6: Korangi Sports Complex" } },
                { "Airport", new List<string> { "Safe Area 7: Airport Lounge", "Safe Area 8: Aviation Academy" } },
                { "Liaquatabad", new List<string> { "Safe Area 9: Community Hall", "Safe Area 10: Town Park" } },
                { "DHA", new List<string> { "Safe Area 11: DHA Club", "Safe Area 12: Seaview Ground" } },
                { "Nazimabad", new List<string> { "Safe Area 13: Sports Complex", "Safe Area 14: Central Library" } },
                { "PECHS", new List<string> { "Safe Area 15: Welfare Hall", "Safe Area 16: PECHS School" } }
            };
        }

        // Method to fetch safe areas for an affected area
        public List<string> GetSafeAreas(string affectedArea)
        {
            return data.ContainsKey(affectedArea) ? data[affectedArea] : new List<string> { "No safe areas available." };
        }

        // Method to add a new safe area for an affected area
        public void AddSafeArea(string affectedArea, string newSafeArea)
        {
            if (data.ContainsKey(affectedArea))
            {
                data[affectedArea].Add(newSafeArea);
            }
            else
            {
                // If the affected area doesn't exist, create a new entry
                data[affectedArea] = new List<string> { newSafeArea };
            }
        }
    }
    //public partial class SafeAreaForm : Form
    //{
    //    public SafeAreaForm()
    //    {
    //        InitializeComponent();
    //    }

    //    private void SafeAreaForm_Load(object sender, EventArgs e)
    //    {

    //    }

    //    private void BtnMarkSafe_Click_1(object sender, EventArgs e)
    //    {
    //        // Mark a new safe area
    //        MessageBox.Show("");

    //    }

    //    private void btnViewDetails_Click(object sender, EventArgs e)
    //    {
    //        // Show details of the selected safe area
    //        if (lstSafeAreas.SelectedItem != null)
    //        {
    //            MessageBox.Show($"Details for {lstSafeAreas.SelectedItem}");
    //        }
    //        else
    //        {
    //            MessageBox.Show("Please select a safe area first.");
    //        }
    //    }
    //    public void UpdateSafeAreas(string affectedArea)
    //    {
    //        // Clear the ListBox before adding new items
    //        lstSafeAreas.Items.Clear();

    //        // Get safe areas for the selected affected area
    //        List<string> safeAreas = safeAreaContext.GetSafeAreas(affectedArea);

    //        // Populate the ListBox with safe areas
    //        foreach (string safeArea in safeAreas)
    //        {
    //            lstSafeAreas.Items.Add(safeArea);
    //        }
    //    }

    //    private void lstSafeAreas_SelectedIndexChanged(object sender, EventArgs e)
    //    {

    //    }
    //}

    //internal class safeAreaContext
    //{
    //    // Example method to fetch safe areas for an affected area
    //    public static List<string> GetSafeAreas(string affectedArea)
    //    {
    //        // Define mappings between affected areas and safe areas
    //        var data = new Dictionary<string, List<string>>
    //    {
    //        { "Saddar", new List<string> { "Safe Area 1: City Park", "Safe Area 2: Community Center" } },
    //        { "Malir", new List<string> { "Safe Area 3: School Shelter", "Safe Area 4: Mosque Ground" } },
    //        { "Korangi", new List<string> { "Safe Area 5: Korangi Stadium", "Safe Area 6: Korangi Sports Complex" } },
    //        { "Airport", new List<string> { "Safe Area 7: Airport Lounge", "Safe Area 8: Aviation Academy" } },
    //        { "Liaquatabad", new List<string> { "Safe Area 9: Community Hall", "Safe Area 10: Town Park" } },
    //        { "DHA", new List<string> { "Safe Area 11: DHA Club", "Safe Area 12: Seaview Ground" } },
    //        { "Nazimabad", new List<string> { "Safe Area 13: Sports Complex", "Safe Area 14: Central Library" } },
    //        { "PECHS", new List<string> { "Safe Area 15: Welfare Hall", "Safe Area 16: PECHS School" } }
    //    };

    //        return data.ContainsKey(affectedArea) ? data[affectedArea] : new List<string> { "No safe areas available." };
    //    }
    //}
}
