using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HomeWork
{
    internal class TeamWork
    {
        public static void SortTeamMembers(IDeveloper[] developers)
        {
            Array.Sort<IDeveloper>(developers);
        }
    }
}
