namespace _06_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create method Div(), which calculates the dividing of two int numbers.
            // In Main() read two int numbers and call this method.
            // Catch appropriative exceptions.
            // 
            // Throwing exception if dividing of two double numbers.

            //Console.WriteLine("Enter numbers:");
            try
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();

                if (
                    int.TryParse(input1, out int num1) &&
                    int.TryParse(input2, out int num2))
                {
                    WorkWithExceptions.Div(num1, num2);
                }
                else
                {
                    throw new ApplicationException("Please, enter an integer value");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Write method ReadNumber(int start, int end),
            // which reads from console integer numbers and returns it,
            // if it is in the range[start...end].
            // If this numbers is invalid or non - number text is read,
            // the method should throw an exception.
            // Using this method write a method Main(), that has to enter 10 numbers:
            // a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

            int[] numbers = new int[10];

            try
            {
                numbers[0] = WorkWithNumbers.ReadNumber(1, 100);

                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i] = WorkWithNumbers.ReadNumber(numbers[i - 1], 100);
                }

                Console.WriteLine(numbers[numbers.Length - 1]);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
