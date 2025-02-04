using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    internal class TornadoSafeAreaStrategy : ISafeAreaStrategy
    {
        // This dictionary holds mappings between affected areas and their corresponding safe areas
        private readonly Dictionary<string, List<string>> safeAreas = new Dictionary<string, List<string>>()
        {
            { "Saddar", new List<string> { "Safe Area 1: City Park", "Safe Area 2: Community Center" } },
            { "Korangi", new List<string> { "Safe Area 3: Korangi Stadium", "Safe Area 4: Korangi Sports Complex" } },
            { "Malir", new List<string> { "Safe Area 5: School Shelter", "Safe Area 6: Mosque Ground" } },
            { "Nazimabad", new List<string> { "Safe Area 7: Sports Complex", "Safe Area 8: Central Library" } },
            { "DHA", new List<string> { "Safe Area 9: DHA Club", "Safe Area 10: Seaview Ground" } },
            { "PECHS", new List<string> { "Safe Area 11: Welfare Hall", "Safe Area 12: PECHS School" } },
            { "Airport", new List<string> { "Safe Area 13: Airport Lounge", "Safe Area 14: Aviation Academy" } }
        };

        // The GetSafeArea method returns a string of safe areas
        public string GetSafeArea(string affectedArea)
        {
            // Check if the affected area has a mapped list of safe areas
            if (safeAreas.ContainsKey(affectedArea))
            {
                // Join the list of safe areas into a single string with line breaks
                return string.Join("\n", safeAreas[affectedArea]);
            }
            else
            {
                return "No safe areas available.";
            }
        }
    }
}
