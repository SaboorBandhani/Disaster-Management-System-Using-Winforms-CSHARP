using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    public class ResourceFactory
    {
        public List<string> GetResources(string disasterType)
        {
            if (disasterType == "Flood")
            {
                return new List<string> { "Medical Kits", "Boats", "Life Jackets" };
            }
            else if (disasterType == "Earthquake")
            {
                return new List<string> { "Tents", "Medical Supplies", "Rescue Dogs" };
            }
            return new List<string>();
        }
    }
}
