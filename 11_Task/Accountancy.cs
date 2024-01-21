using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Task
{
    internal class Accountancy
    {
        // Create a class Accountancy, a method of PayingFellowship
        // (which prints will be a student have a scholarship or not).
        // Sign this method on the student event MarkChange

        public void PayingFellowship(int m)
        {
            if (3<m)
            {
                Console.WriteLine($"have scholarship");
            }
            else
            {
                Console.WriteLine($"don't have scholarship");
            }
        }
    }
}
