using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_HomeWork
{
    internal class Programmer : IDeveloper
    {
        private string language;

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public string Tool
        {
            get; set;
        }

        public Programmer() : this("C#", "MS Studio")
        {

        }

        public Programmer (string language, string tool)
        {
            this.language = language;
            Tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Programmer created");
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer destroyed");
        }

        //-----

        public static bool operator ==(Programmer a, Programmer b)
        {
            return a.Tool == b.Tool;
        }
        public static bool operator !=(Programmer a, Programmer b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            return obj is Programmer anotherPerson ? Tool == anotherPerson.Tool : false;
        }

        public override int GetHashCode()
        {

            return base.GetHashCode();
        }
    }
}
