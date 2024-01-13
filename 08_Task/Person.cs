using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Task
{
    internal class Person : IComparable<Person>
    {
        private string name;

        public Person (string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }


        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
        public int CompareTo(Person? other)
        {
            return this.Name.CompareTo(other!.Name);
        }
    }
}
