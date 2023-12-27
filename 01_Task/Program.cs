namespace _01_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int a2; int b;
            a2 = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a + b = {a2 + b}");
            Console.WriteLine($"a - b = {a2 - b}");
            Console.WriteLine($"a * b = {a2 * b}");
            Console.WriteLine($"a / b = {a2 / b}");
            Console.WriteLine();

            //2
            Console.WriteLine("How are you?");
            string answer;
            answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
            Console.WriteLine();

            //3
            char first, second, third;
            first = char.Parse(Console.ReadLine());
            second = char.Parse(Console.ReadLine());
            third = char.Parse(Console.ReadLine());
            Console.WriteLine($"You enter ({first}), ({second}), ({third})");
            Console.WriteLine();

            //4
            int firstNumber;
            int secondNumber;
            firstNumber = int.Parse(Console.ReadLine());
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine((firstNumber > 0) && (secondNumber > 0));
        }
    }
}
