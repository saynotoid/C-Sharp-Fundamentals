using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Task
{
    internal class Parent
    {
        // Create class Parent with the method OnMarkChange
        // (which receives an int estimate and displays it on the console)

        public void OnMarkChange(int estimate)
        {
            Console.WriteLine($"estimate: {estimate}");
        }
    }
}
