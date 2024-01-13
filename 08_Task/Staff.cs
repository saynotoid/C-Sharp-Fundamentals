using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Task
{
    internal class Staff : Person
    {
        private int salary;

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public int Salary
        {
            get { return salary; }
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }

        public override string ToString()
        {
            return String.Format("Person {0} has salary: ${1}", Name, this.salary);
        }
    }
}
