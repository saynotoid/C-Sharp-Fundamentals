using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_HomeWorkA
{
    internal class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }

        public override int CompareTo(Shape other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}
