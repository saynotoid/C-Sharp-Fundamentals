using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_HomeWorkA
{
    internal abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return Name;
        }
    }
}