using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Task
{
    internal class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public string Subject
        {
            get { return subject; }
        }

        public sealed override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1} and is teaching {2}",
                Name, this.Salary, this.subject);
        }
    }
}
