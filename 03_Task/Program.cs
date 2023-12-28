namespace _03_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

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
            // Enter some string text from the console.
            // Print each second character.

            Console.Write("Enter some string -> ");
            string text = Console.ReadLine();
            for (int i = 1; i < text.Length; i += 2)
            {
                Console.Write(text[i]);
            }

        }

        static void Task3()
        {
            // 3
            // Enter the name of the drink(coffee, tea, juice, water).
            // Print the name and price of the drink.

            Drink[] drinks =
                [
                    new Drink { Name = DrinkName.coffee, Price = 24.50 },
                    new Drink { Name = DrinkName.tea, Price = 5.50 },
                    new Drink { Name = DrinkName.juice, Price = 22.22 },
                    new Drink { Name = DrinkName.water, Price = 2.13 }
                    ];

            Console.Write("Enter the name of the drink(coffee, tea, juice, water) -> ");

            if (Enum.TryParse(Console.ReadLine(), true, out DrinkName drinkName))
            {
                Console.WriteLine(drinks[(int)drinkName]);
            }
            else
            {
                Console.WriteLine("Not a drink :(");
            }
        }
        enum DrinkName { coffee, tea, juice, water }
        struct Drink
        {
            public DrinkName Name { get; set; }
            public double Price { get; set; }

            public override string ToString()
            {
                return String.Format($"The price for the {Name} is {Price} :)");
            }
        }

        static void Task4()
        {
            // 4
            // Enter a sequence of positive integers(to the first negative).
            // Calculate the arithmetic average of the entered positive numbers.
            // //1,6,3,9,-8 -> (1+6+3+9)/4

            Console.WriteLine("Enter a sequence of positive integers(to the first negative) -> ");
            int sum = 0;
            int count = 0;
            int number = 0;
            string result = "";

            do
            {
                int.TryParse(Console.ReadLine(), out number);
                if (number >= 0)
                {
                    sum += number;
                    count++;
                    result += number + "+";
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine($"({result.Remove(result.Length - 1, 1)})/{count} = {(double)sum / count}");
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

            Console.Write("Enter year -> ");
            int.TryParse(Console.ReadLine(), out int year);

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                {
                    Console.WriteLine($"{year} рік високосний");
                }
                else
                {
                    Console.WriteLine($"{year} - ні");
                }
            }
            else
            {
                Console.WriteLine($"{year} - ні");
            }
        }
        
        static void Task6()
        {
            // 6
            // Find the sum of digits of the entered integer number
            // //(365 -> 3+6+5)

            Console.Write("Enter integer number -> ");
            string numS = Console.ReadLine();
            int sum = 0;

            if (int.TryParse(numS, out int nothing))
            {
                for (int i = 0; i < numS.Length; i++)
                {
                    sum += Convert.ToInt32(numS[i].ToString());
                }
            }

            Console.WriteLine($"The sum of digits of the number {numS} -> {sum}");
        }
        
        static void Task7()
        {
            // 7
            // Check if the entered integer number contains only odd digits.

            Console.Write("Enter integer number -> ");
            string num = Console.ReadLine();
            bool flag = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (Convert.ToInt32(num[i].ToString()) % 2 != 0)
                {
                    continue;
                }
                else
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Contains not only odd");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Yes, contains only odd digits");
            }
        }
    }
}
