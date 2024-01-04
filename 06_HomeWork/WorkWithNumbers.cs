using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_HomeWork
{
    internal class WorkWithNumbers
    {
        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int number = 0;

            try
            {
                if (!int.TryParse(input, out number))
                {
                    throw new ArgumentException("Please, enter an integer value");
                }
                else if (start <= number && number <= end)
                {
                    return number;
                }
                else
                {
                    throw new ArgumentException("Wrong value");
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}
