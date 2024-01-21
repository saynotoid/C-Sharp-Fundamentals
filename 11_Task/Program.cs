namespace _11_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Delegate void MyDel (int m)
            //
            // Create class Student with names and marks(a type of list <int>),
            // event MarkChange of the type MyDel
            // and the method AddMark(adds a new mark to the list of marks).
            //
            // Create class Parent with the method OnMarkChange
            // (which receives an int estimate and displays it on the console)
            //
            // In Main, create a student, parent,
            // sign the parent method of OnMarkChange on the student event MarkChange.
            // Call the method AddMark several times.
            //
            // Create a class Accountancy, a method of PayingFellowship
            // (which prints will be a student have a scholarship or not).
            // Sign this method on the student event MarkChange

            Student student = new Student();

            Parent parent = new Parent();

            student.MarkChange += parent.OnMarkChange;

            Accountancy accountancy = new Accountancy();

            student.MarkChange += accountancy.PayingFellowship;

            student.AddMark(4);
            student.AddMark(2);
            student.AddMark(5);
            student.AddMark(5);
            student.AddMark(3);
            student.AddMark(4);
        }

        public delegate void MyDel(int m);
    }
}
