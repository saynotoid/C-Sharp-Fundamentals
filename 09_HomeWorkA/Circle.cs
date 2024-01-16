using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_HomeWorkA
{
    internal class Circle : Shape
    {
        public const double pi = 3.14;
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return pi * Radius * Radius;
        }
        public override double Perimeter()
        {
            return 2 * pi * Radius;
        }
    }
}
