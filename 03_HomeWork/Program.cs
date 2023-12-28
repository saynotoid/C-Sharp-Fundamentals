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
            //HomeWork2();
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

            Month[] months =
                [
                    new Month { Name = Months.January, CountOfDays = 31 },
                    new Month { Name = Months.February, CountOfDays = 28 },
                    new Month { Name = Months.March, CountOfDays = 31 },
                    new Month { Name = Months.April, CountOfDays = 30 },
                    new Month { Name = Months.May, CountOfDays = 31 },
                    new Month { Name = Months.June, CountOfDays = 30 },
                    new Month { Name = Months.July, CountOfDays = 31 },
                    new Month { Name = Months.August, CountOfDays = 31 },
                    new Month { Name = Months.September, CountOfDays = 30 },
                    new Month { Name = Months.October, CountOfDays = 31 },
                    new Month { Name = Months.November, CountOfDays = 30 },
                    new Month { Name = Months.December, CountOfDays = 31 }
                ];

            Console.Write("Enter the number of month -> ");

            if (int.TryParse(Console.ReadLine(), out int numOfMonth))
            {
                Console.WriteLine(months[numOfMonth - 1]);
            }
            else
            {
                Console.WriteLine("Not a number of the month :(");
            }

            Console.WriteLine();

        }
        enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December }
        struct Month
        {
            public Months Name { get; set; }
            public byte CountOfDays { get; set; }

            public override string ToString()
            {
                return String.Format($"Count of days in {Name} is {CountOfDays}");
            }
        }

        static void HomeWork3()
        {
            // Enter 10 integer numbers.
            // Calculate the sum of first 5 elements if they are positive
            // or product of last 5 element in the other case.

            int[] numbers = new int[10];
            bool firstFiveArePositive = true;
            int sum = 0;
            int mult = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {

                }
                else
                {
                    Console.WriteLine("NaN");
                    break;
                    //TODO: full exit, no CW later
                }
            }
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if ((numbers[i] < 0))
                {
                    firstFiveArePositive = false;
                }
                else
                {
                    sum+= numbers[i];
                }
            }
            if (firstFiveArePositive)
            {
                Console.WriteLine($"The sum of first 5 elements is {sum}");
            }
            else
            {
                for (int i = numbers.Length / 2; i < numbers.Length; i++)
                {
                    mult *= numbers[i];
                }
                Console.WriteLine($"Product of last 5 element is {mult}");
            }
        }
    }
}
