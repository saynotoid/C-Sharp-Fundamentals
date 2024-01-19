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
            : this(
                  new Point() { X = 0, Y = 0 },
                  new Point() { X = 0, Y = 0 },
                  new Point() { X = 0, Y = 0 })
        {

        }

        public double Perimeter()
        {
            return vertex1.DistanceTo(vertex2) + vertex1.DistanceTo(Vertex3) + vertex2.DistanceTo(vertex3);
        }

        public double Area()
        {
            // формула Герона
            double sideA = vertex1.DistanceTo(vertex2);
            double sideB = vertex1.DistanceTo(Vertex3);
            double sideC = vertex2.DistanceTo(vertex3);

            double perimeterHalved = Perimeter() / 2;

            double area = Math.Sqrt(
                perimeterHalved
                * (perimeterHalved - sideA) 
                * (perimeterHalved - sideB) 
                * (perimeterHalved - sideC));

            return area;
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
