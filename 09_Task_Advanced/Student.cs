using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Task_Advanced
{
    internal class Student
    {
        public int Rating { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public List<string> Subjects { get; } = new List<string>();

        public Student(int rating, string name, string group, List<string> subjects)
        {
            Rating = rating;
            Name = name;
            Group = group;
            Subjects = subjects;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return Name == otherStudent.Name
                    && Rating == otherStudent.Rating
                    && Group == otherStudent.Group;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Rating;
        }
    }
}
