using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace _03_Task_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.WriteLine(LeastCommonMultiple(14, 8));
            Console.WriteLine(SumOfTwoMaxElements(new int[] { 4, 5, 6, 7, 3, 12, -5, 1, 0, 12 }));
        }
        public static uint LeastCommonMultiple(uint value1, uint value2)
        {
            return value1 * value2 / GreatestCommonDivisor(value1, value2);
        }
        public static uint GreatestCommonDivisor(uint value1, uint value2)
        {
            uint min = value1 < value2 ? value1 : value2;
            uint LCM = 1;
            if (value1 == 1 || value2 == 1)
            {
                return 1;
            }
            else
            {
                for (uint i = 2; i <= min; i++)
                {
                    if (value1 % i == 0 && value2 % i == 0)
                        LCM = i;
                    else
                        continue;
                }
                return LCM;
            }
        }

        public static int SumOfTwoMaxElements(int[] array)
        {
            // Please, implement the SumOfTwoMaxValues method.
            // The method takes an array of integers with a length greater than on equal to 2.
            // It should return a sum of two max elements of the array

            int max1 = 0, max2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                max1 = array[i] < max1 ? max1 : array[i];
            }

            int max1count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max1)
                    ++max1count;
            }

            if (1 < max1count)
                return max1 * 2;
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != max1)
                        max2 = array[i] < max2 ? max2 : array[i];
                    else continue;
                }

                return max1 + max2;
            }
        }
    }
}
