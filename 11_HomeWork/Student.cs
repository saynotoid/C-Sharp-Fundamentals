using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _11_HomeWork.Program;

namespace _11_HomeWork
{
    internal class Student
    {
        // Create class Student with names and marks(a type of list <int>),
        // event MarkChange of the type MyDel
        // and the method AddMark(adds a new mark to the list of marks).

        private List<int> marks = new List<int>();

        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            marks.Add(mark);
            MarkChange(mark);
        }
    }
}
