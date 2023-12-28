using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HomeWork1();
            HomeWork2();
            //HomeWork3();

        }

        static void HomeWork1()
        {
            // Read some string str.
            // Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’ in this text.

            Console.Write("Enter some string str -> ");
            string str = Console.ReadLine();

            int countA = 0, countO = 0, countI = 0, countE = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Enum.TryParse(str[i].ToString(), true, out characters character))
                    switch (character)
                    {
                        case characters.a: countA++; break;
                        case characters.o: countO++; break;
                        case characters.i: countI++; break;
                        case characters.e: countE++; break;
                        default: break;
                    }
            }

            Console.WriteLine($"The counts of characters are:\n" +
                $"‘a’:{countA}, ’o’: {countO}, ’i’: {countI}, ’e’: {countE} in this text.");
        }

        enum characters { a, o, i, e }

        static void HomeWork2()
        {
            // Ask user to enter the number of month.
            // Read value and output the count of days in this month.

        }

        static void HomeWork3()
        {
            // Enter 10 integer numbers.
            // Calculate the sum of first 5 elements
            // if they are positive or product of last 5 element in  the other case.

        }
    }
}
