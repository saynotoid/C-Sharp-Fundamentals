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
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}
