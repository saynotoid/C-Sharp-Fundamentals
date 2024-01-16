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

        public string Name
        {
            get { return name; }
            set
            {
            }
        }

        public abstract double Area();

        public abstract double Perimeter();
        
        public abstract int CompareTo(Shape? other);
    }
}