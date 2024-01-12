using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Task
{
    internal class Developer : Staff
    {
        private int level;

        public Developer(string name, int salary, int level) : base(name, salary)
        {
            this.level = level;
        }

        public int Level
        {
            get { return level; }
        }

        public sealed override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and is of {2} level",
                Name, this.Salary, this.level);
        }
    }
}
