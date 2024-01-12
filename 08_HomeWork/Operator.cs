using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace _08_HomeWork
{
    internal class Operator
    {
        public static void GetInfo(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
        }

        public static void GetLargestPerimeter(List<Shape> shapes)
        {
            double maxPerimeter = shapes[0].Perimeter();
            int index = 0;

            foreach (Shape shape in shapes)
            {
                double perimeter = shape.Perimeter();
                if (maxPerimeter < perimeter)
                {
                    maxPerimeter = perimeter;
                    index = shapes.IndexOf(shape);
                }
            }

            Console.WriteLine($"Name: {shapes[index].Name}");
        }

        public static void Sort(List<Shape> shapes)
        {
            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Name);
            }
        }
    }
}
