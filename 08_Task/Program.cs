using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;

namespace _08_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Add two classes Persons and Staff (use the presentation code)
            //
            // 2.Create two classes Teacher and Developer, derived from Staff.
            //  Add field subject for class Teacher;
            //  Add field level for class Developer;
            //  override method Print for both classes.
            //
            //  3. In Main, specify a list of Person type and add objects of each type to it.
            //  Call for each item in the list method Print ().
            //
            //  4. Enter the person's name.
            //  If this name present in  list - print information about this person
            //
            //  5. Sort list by name, output to file
            //
            //  6*. Create a list of Employees and move only workers(teachers+developers) there.
            //  Sort them by salary.

            // IComparer -> Array.Sort() // зовнішній компаратор
            //Array.Sort( array = new Array();

            List<Person> people = new List<Person>()
            {
                new Staff("staff1", 100),
                new Teacher("teacher1",150,"subject1"),
                new Developer("developer1",2000,2)
            };

            foreach (Person person in people) 
            {
                person.Print();
            }


        }
    }
}
