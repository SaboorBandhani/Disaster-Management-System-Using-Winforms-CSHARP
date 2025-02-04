using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisasterManagementSystem
{
    public interface ISafeAreaStrategy
    {
        string GetSafeArea(string affectedArea);
    }
}
