using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Task
{
    internal class Student
    {
        // Create class Student with names and marks(a type of list <int>),
        // event MarkChange of the type MyDel
        // and the method AddMark(adds a new mark to the list of marks).

        private string _name;
        private List<int> _marks = new List<int>();

        public event Program.MyDel MarkChange;

        public void AddMark(int mark)
        {
            _marks.Add(mark);
            MarkChange((int)_marks.Average());
        }
    }
}
