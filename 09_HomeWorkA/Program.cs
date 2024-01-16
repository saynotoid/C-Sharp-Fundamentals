using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace _09_HomeWorkA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A) Create Console Application project.
            // Use classes Shape, Circle, Square from your previous homework.
            // Use Linq and string functions to complete next tasks:
            // 
            // 1) Create list of Shape and fill it with 6 different shapes(Circle and Square).
            // 2) Find and write into the file shapes with area from range[10, 100]
            // 3) Find and write into the file shapes which name contains letter 'a'
            // 4) Find and remove from the list all shapes with perimeter less then 5.
            // Write resulted list into Console

            List<Shape> shapes = new List<Shape>()
            {
                new Circle("circle1", 3),
                new Square("square1", 5),
                new Circle("circle2", 6),
                new Square("square2", 8),
                new Circle("circle3", 1),
                new Square("square3", 1)
            };

            /*
            using (StreamWriter sw = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                @"shapes with area from range[10, 100].txt")))
            */
            using (StreamWriter sw = new StreamWriter(@"shapes with area from range[10, 100].txt"))
            {
                foreach (var item in shapes.Where(shape => 10 <= shape.Area() && shape.Area() <= 100))
                {
                    sw.WriteLine(InfoClass.Info(item));
                }
            }

            /*
            using (StreamWriter sw = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                @"shapes which name contains letter 'a'.txt")))
            */
            using (StreamWriter sw = new StreamWriter(@"shapes which name contains letter 'a'.txt"))
            {
                foreach (var item in shapes.Where(shape => shape.Name.Contains('a') == true))
                {
                    sw.WriteLine(InfoClass.Info(item));
                }
            }

            shapes = shapes.Where(shape => 5 <= shape.Perimeter()).ToList();

            /*
            shapes = (from shape in shapes
                     where 5 <= shape.Perimeter()
                     select shape).ToList();
            */

            //shapes.Remove((shape => 5 <= shape.Perimeter());


            Console.WriteLine("list:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(InfoClass.Info(shape));
            }
        }

    }

    internal static class InfoClass
    {
        public static string Info(this Shape shape)
        {
            if (shape is Square)
            {
                return String.Format($"Name: {shape.Name}, Area: {shape.Area():0.##}, Perimeter: {shape.Perimeter():0.##}");
            }
            else if (shape is Circle)
            {
                return String.Format($"Name: {shape.Name}, Area: {shape.Area():0.##}, Perimeter: {shape.Perimeter():0.##}");
            }
            else
            {
                return String.Format($"Unknown type input");
            }
        }
    }
}
