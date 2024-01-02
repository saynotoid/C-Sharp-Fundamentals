using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HomeWork
{
    internal class Builder : IDeveloper
    {
        private string tool;

        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }

        public Builder() : this("Hammer")
        {

        }

        public Builder (string tool)
        {
            this.tool = tool;
        }

        public void Create()
        {
            Console.WriteLine("Builder created");
        }

        public void Destroy()
        {
            Console.WriteLine("Builder destroyed");
        }

        public int CompareTo(IDeveloper other)
        {
            return this.Tool.CompareTo(other.Tool);
        }

        //-----
        public static bool operator ==(Builder a, Builder b)
        {
            return a.Tool == b.Tool;
        }
        public static bool operator !=(Builder a, Builder b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            return obj is Builder anotherPerson ? Tool == anotherPerson.Tool : false;
        }

        public override int GetHashCode()
        {

            return base.GetHashCode();
        }
    }
}
