using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Create abstract class Shape with field name and property Name.
            //
            // Add constructor with 1 parameter and abstract methods Area() and Perimeter(),
            // which can return area and perimeter of shape;
            //
            // 2) Create classes Circle, Square derived from Shape
            // with field radius(for Circle) and side(for Square).
            //
            // Add necessary constructors, properties to these classes,
            // override methods from abstract class Shape.
            //
            // a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.
            // Write name, area and perimeter of all shapes.
            //
            // b) Find shape with the largest perimeter and print its name.
            //
            // 3) Sort shapes by area and print obtained list(Remember about IComparable)

            //List<Shape> shapes = new List<Shape>();

            //for (int i = 0; i < 10; i++)
            //{
            //    shapes.Add(new Circle("circle", 2));
            //}

            //Operator.GetInfo(shapes);

            //Operator.GetLargestPerimeter(shapes);

            List<Shape> shapes = new List<Shape>
            {
                new Circle("circle1", 2),
                new Circle("circle1", 3),
                new Square("square1 ", 2),
                new Square("square2 ", 8)
            };

            Operator.Sort(shapes);
        }
    }
}
