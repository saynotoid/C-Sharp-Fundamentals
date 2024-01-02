using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_HomeWork
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        public string Tool { get; set; }
        public void Create() { }
        public void Destroy() { }

        public int CompareTo(IDeveloper other)
        {
            return this.Tool.CompareTo(other.Tool);
        }
    }
}
