using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _10_HomeWork
{
    public class Triangle
    {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;

        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
        }

        public Triangle()
            : this(new Point(0, 0), new Point(0, 0), new Point(0, 0))
        {

        }

        public double Perimeter()
        {
            return vertex1.DistanceTo(vertex2) + vertex2.DistanceTo(vertex3) + vertex3.DistanceTo(Vertex1);
        }

        public double Area()
        {
            // формула Герона
            double perimeterHalved = Perimeter() / 2;

            return Math.Sqrt(
                perimeterHalved
                * (perimeterHalved - vertex1.DistanceTo(vertex2))
                * (perimeterHalved - vertex2.DistanceTo(Vertex3))
                * (perimeterHalved - vertex3.DistanceTo(vertex1)));
        }

        public Point ClosestVertexToOrigin()
        {
            List<Point> vertices = new List<Point>() { Vertex1, Vertex2, Vertex3 };

            return vertices
                .Aggregate((closest, next)
                => closest.DistanceToOrigin() <= next.DistanceToOrigin() ? closest : next);
        }

        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {Vertex1}, {Vertex2}, {Vertex3}" +
                $"\nPerimeter: {Perimeter()}" +
                $"\nArea: {Area()}");
        }
    }
}
