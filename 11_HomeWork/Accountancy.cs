using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HomeWork
{
    internal class Accountancy
    {
        // Create a class Accountancy, a method of PayingFellowship
        // (which prints will be a student have a scholarship or not).
        // Sign this method on the student event MarkChange

        public void PayingFellowship(int m)
        {
            if (75 <= m)
            {
                Console.WriteLine($"Student will receive a scholarship.");
            }
            else
            {
                Console.WriteLine($"Student will not receive a scholarship.");
            }
        }
    }
}
