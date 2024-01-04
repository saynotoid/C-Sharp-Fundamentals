using System.Drawing;

namespace _06_Task_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a method for calculating an area of a rectangle
            // int GetRectangleArea(int a, int b),
            // which should throw an ArgumentException
            // if at least one of its arguments is negative and
            // throw OverflowException if area bigger than Int32.MaxValue.
            // 
            // Create TryGetRectangleArea method
            // which takes two parameters and calls GetRectangleArea
            // to evaluate an area of a rectangle.
            // Catch exceptions that can be generated and print the exception message if caught.
            //
            // TryGetRectangleArea shouldn't generate any exceptions.
            // In case when ArgumentException or OverflowException  is caught the method should return 0;

            Console.WriteLine(Operation.GetRectangleArea(-1, 2));

            Console.WriteLine(Operation.TryGetRectangleArea(1, 2));


        }
    }
}
