using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_HomeWork
{
    internal class WorkWithExceptions
    {
        public static void Div(int num1, int num2)
        {
            try
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cathced");
                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }
            }
            catch (DivideByZeroException ex)
            {
                throw;
            }
        }
    }
}
