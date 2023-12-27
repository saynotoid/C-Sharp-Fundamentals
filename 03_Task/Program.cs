namespace _03_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            Task2();

            //Task3();

            //Task4();

            //Task5();

            //Task6();

            //Task7();
        }

        static void Task1()
        {
            // 1
            // Enter two integer numbers a and b.
            // Calculate how many integers in the range [a..b] are divided by 3 without remainder.
            // //1..10 -> 3

            Console.Write("Input int a -> ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Input int b -> ");
            int.TryParse(Console.ReadLine(), out int b);

            byte countIntegers = 0;
            for (int i = a; i < b + 1; i++)
            {
                if (i % 3 == 0)
                {
                    countIntegers++;
                }
            }
            Console.WriteLine($"Answer is {countIntegers}");
        }

        static void Task2()
        {
            // 2
            // Enter some string text from the console.Print each second character.

        }

        static void Task3()
        {
            // 3
            // Enter the name of the drink(coffee, tea, juice, water).
            // Print the name and price of the drink.

        }
        static void Task4()
        {
            // 4
            // Enter a sequence of positive integers(to the first negative).
            // Calculate the arithmetic average of the entered positive numbers.
            // //1,6,3,9,-8 -> (1+6+3+9)/4

        }
        static void Task5()
        {
            // 5
            // Check if the entered year is a leap.
            // 2000 рік високосний, а 1900 – ні
            // Якщо рік ділиться на 4 без остачі if(year % 4 == 0)
            //{
            //Якщо рік не ділиться на 100 або рік ділиться на 100 проте також ділиться на 400. 
            //if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))

        }
        static void Task6()
        {
            // 6
            // Find the sum of digits of the entered integer number
            // //(365 -> 3+6+5)

        }
        static void Task7()
        {
            // 7
            // Check if the entered integer number contains only odd digits.

        }
    }
}
