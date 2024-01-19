using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Task
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

        public double Distance(Point point1, Point point2)
        {
            double deltaX;
            double deltaY;

            if (point1.X < point2.X)
            {
                if (0 <= point2.X && 0 <= point1.X)
                {
                    deltaX = point2.X - point1.X;
                }
                else if (0 <= point2.X && point1.X <= 0)
                {
                    deltaX = point2.X + Math.Abs(point1.X);
                }
                else
                {
                    deltaX = Math.Abs(point1.X) - Math.Abs(point2.X);
                }
            }
            else
            {
                if (0 <= point1.X && 0 <= point2.X)
                {
                    deltaX = point1.X - point2.X;
                }
                else if (0 <= point1.X && point2.X <= 0)
                {
                    deltaX = point1.X + Math.Abs(point2.X);
                }
                else
                {
                    deltaX = Math.Abs(point2.X) - Math.Abs(point1.X);
                }
            }

            if (point1.Y < point2.Y)
            {
                if (0 <= point2.Y && 0 <= point1.Y)
                {
                    deltaY = point2.Y - point1.Y;
                }
                else if (0 <= point2.Y && point1.Y <= 0)
                {
                    deltaY = point2.Y + Math.Abs(point1.Y);
                }
                else
                {
                    deltaY = Math.Abs(point1.Y) - Math.Abs(point2.Y);
                }
            }
            else
            {
                if (0 <= point1.Y && 0 <= point2.Y)
                {
                    deltaY = point1.Y - point2.Y;
                }
                else if (0 <= point1.Y && point2.Y <= 0)
                {
                    deltaY = point1.Y + Math.Abs(point2.Y);
                }
                else
                {
                    deltaY = Math.Abs(point2.Y) - Math.Abs(point1.Y);
                }
            }

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            return distance;
        }

        public double Perimeter()
        {
            double sideA;
            double sideB;
            double sideC;

            sideA = Distance(Vertex1, Vertex2);
            sideB = Distance(Vertex2, Vertex3);
            sideC = Distance(Vertex3, Vertex1);

            double perimeter = sideA + sideB + sideC;

            return perimeter;
        }

        public double Area()
        {
            // формула Герона
            double sideA;
            double sideB;
            double sideC;

            sideA = Distance(Vertex1, Vertex2);
            sideB = Distance(Vertex2, Vertex3);
            sideC = Distance(Vertex3, Vertex1);

            double perimeterHalved = Perimeter() / 2;

            double area = Math.Sqrt(
                perimeterHalved
                * (perimeterHalved - sideA) 
                * (perimeterHalved - sideB) 
                * (perimeterHalved - sideC));

            return area;
        }

        public void Print()
        {
            Console.WriteLine($"Трикутник з" +
                $"\nкоординатами: {Vertex1}, {Vertex2}, {Vertex3}," +
                $"\nсторонами довжиною: " +
                $"{Distance(Vertex1, Vertex2):f2}, {Distance(Vertex2, Vertex3):f2} та {Distance(Vertex3, Vertex1):f2}," +
                $"\nмає периметр: {Perimeter():f2}," +
                $"\nта площу: {Area():f2}");
            Console.WriteLine();
        }
    }
}
