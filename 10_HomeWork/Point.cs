using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_HomeWork
{
    public struct Point
    {
        private double x;
        private double y;

        public double X
        {
            get => x; set { x = value; }
        }

        public double Y
        {
            get => y; set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point point)
        {
            double deltaX;
            double deltaY;

            if (X < point.X)
            {
                if (0 <= point.X && 0 <= X)
                {
                    deltaX = point.X - X;
                }
                else if (0 <= point.X && X <= 0)
                {
                    deltaX = point.X + Math.Abs(X);
                }
                else
                {
                    deltaX = Math.Abs(X) - Math.Abs(point.X);
                }
            }
            else
            {
                if (0 <= X && 0 <= point.X)
                {
                    deltaX = X - point.X;
                }
                else if (0 <= X && point.X <= 0)
                {
                    deltaX = X + Math.Abs(point.X);
                }
                else
                {
                    deltaX = Math.Abs(point.X) - Math.Abs(X);
                }
            }

            if (Y < point.Y)
            {
                if (0 <= point.Y && 0 <= Y)
                {
                    deltaY = point.Y - Y;
                }
                else if (0 <= point.Y && Y <= 0)
                {
                    deltaY = point.Y + Math.Abs(Y);
                }
                else
                {
                    deltaY = Math.Abs(Y) - Math.Abs(point.Y);
                }
            }
            else
            {
                if (0 <= Y && 0 <= point.Y)
                {
                    deltaY = Y - point.Y;
                }
                else if (0 <= Y && point.Y <= 0)
                {
                    deltaY = Y + Math.Abs(point.Y);
                }
                else
                {
                    deltaY = Math.Abs(point.Y) - Math.Abs(Y);
                }
            }

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            return distance;
        }

        public double DistanceToOrigin()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public override string ToString()
        {
            return string.Format($"({x},{y})");
        }
    }
}
