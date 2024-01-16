using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_HomeWorkA
{
    internal class Operator
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void Sort()
        {
            foreach (Shape shape in shapes.OrderBy(shape => shape.Area()))
            {
                Console.WriteLine(shape);
            }
        }

        public void FindIn10To100Range()
        {
            foreach (Shape shape in shapes.Where(shape => 10 < shape.Area() && shape.Area() < 100))
            {
                Console.WriteLine(shape);
            }
        }

        public void FindContaininga()
        {
            foreach (Shape shape in shapes.Where(shape => shape.Name.Contains('a') == true))
            {
                Console.WriteLine(shape);
            }
        }

        public void RemoveWithPerimeterLessThan5()
        {
            foreach (Shape shape in shapes = shapes.Where(shape => 5 <= shape.Perimeter()).ToList())
            {
                Console.WriteLine(shape);
            }
        }
    }
}