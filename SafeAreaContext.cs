using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    public class SafeAreaContext
    {
        private ISafeAreaStrategy strategy;

        public void SetStrategy(ISafeAreaStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string GetSafeArea(string affectedArea)
        {
            // Define mappings between affected areas and safe areas
            var data = new Dictionary<string, List<string>>
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

            if (data.ContainsKey(affectedArea))
            {
                // Return the safe areas as a single string, separated by commas
                return string.Join(", ", data[affectedArea]);
            }
            else
            {
                return "No safe areas available.";
            }
        }
    }
    
}
