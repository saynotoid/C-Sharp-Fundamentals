using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Task_Advanced
{
    internal class Operation
    {
        public static int GetRectangleArea(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new ArgumentException();
            }
            else if (Int32.MaxValue / a <= b)
            {
                throw new OverflowException();
            }
            else
            {
                return a * b;
            }
        }

        public static int TryGetRectangleArea(int a, int b)
        {
            try
            {
                return GetRectangleArea(a, b);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
