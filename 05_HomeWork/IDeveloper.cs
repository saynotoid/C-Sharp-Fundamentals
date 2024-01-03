using System;
using System.Collections;
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

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return this.Tool.CompareTo(other.Tool);
        }
    }
}
