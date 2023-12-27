namespace _01_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeWork1_1();

            HomeWork1_2();

            HomeWork1_3();

            //test
            int i = 3;
            double d = 5.2;

            System.Console.WriteLine(i);

            System.Console.WriteLine(d);

            System.Console.WriteLine("first {0} second {1}", i, d);
        }

        static void HomeWork1_1()
        {
            int a;

            Console.Write("Input side of the square a -> ");

            if (int.TryParse(Console.ReadLine(), out a))
            {
                int area = a * a;
                int perimeter = a * 4;
                Console.WriteLine($"Area: {area}\nPerimeter: {perimeter}");
            }
            else
            {
                Console.WriteLine("Please, enter an integer value");
            }
        }

        static void HomeWork1_2()
        {
            string name = "";
            int age = 0;

            Console.WriteLine("What is your name?");

            name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}?");

            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"Hello {name}, you are {age} years old :)");
            }
            else
            {
                Console.WriteLine("Entered age is not a number!");
            }
        }

        static void HomeWork1_3()
        {
            Console.Write("Input radius of a circle -> ");
            double r = 0.0; //radius of a circle
            Double.TryParse(Console.ReadLine(), out r);

            const double PI = 3.14;

            double length = 2 * PI * r; //(l=2*pi*r)
            double area = PI * r * r; //(S=pi*r*r)
            double volume = 4 / 3 * PI * r * r * r; //(4/3*pi*r*r*r)
            Console.WriteLine($"length: {length}\narea: {area}\nvolume: {volume}");

        }
    }
}
