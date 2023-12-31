using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_HomeWork
{
    internal class Person
    {
        private string _name;
        private DateTime _birthYear;

        public string Name
        {
            get { return _name; }
        }
        public DateTime BirthYear
        {
            get { return _birthYear; }
        }

        public Person() : this("Unknown", DateTime.Now)
        {

        }
        public Person(string name, DateTime birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - _birthYear.Year;
        }

        public void Input()
        {
            _name = Console.ReadLine();
            _birthYear = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        }
        public void ChangeName(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return String.Format($"Name: {_name}, Year of Birth: {_birthYear.Year}");
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person a, Person b)
        {
            return a._name == b._name;
        }
        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            return obj is Person anotherPerson ? _name == anotherPerson._name : false;
        }
    }
}
