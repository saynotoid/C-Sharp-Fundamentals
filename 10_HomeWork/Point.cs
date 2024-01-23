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

        private double Delta(double arg1, double arg2)
        {
            double min;
            double max;
            if (arg1 < arg2)
            {
                min = arg1;
                max = arg2;
            }
            else
            {
                min = arg2;
                max = arg1;
            }

            if (0 <= max && 0 <= min)
            {
                return max - min;
            }
            else if (0 <= max && min <= 0)
            {
                return max + Math.Abs(min);
            }
            else
            {
                return Math.Abs(max) - Math.Abs(min);
            }
        }

        public double DistanceTo(Point point)
        {
            return Math.Sqrt(Math.Pow(Delta(X, point.X), 2)
                + Math.Pow(Delta(Y, point.Y), 2));
        }

        public double DistanceToOrigin()
        {
            return DistanceTo(new Point(0, 0));
        }

        public override string ToString()
        {
            return string.Format($"({x},{y})");
        }
    }
}
