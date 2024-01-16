using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _09_Task_Advanced
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            // 1

            List<Student> students = new List<Student>();
            students.Add(new Student(98, "98", "98a", new List<string> { "Math", "IT" }));
            students.Add(new Student(64, "64", "64a", new List<string> { "Math", "IT" }));
            students.Add(new Student(76, "76", "76a", new List<string> { "English", "IT" }));
            students.Add(new Student(42, "42", "42a", new List<string> { "English", "IT" }));
            students.Add(new Student(97, "97", "97a", new List<string> { "Potato", "IT" }));
            students.Add(new Student(66, "66", "66a", new List<string> { "Potato", "IT" }));

            foreach (Student student in Filter(students))
            {
                Console.WriteLine(student.Name + student.Group + student.Rating + student.Subjects[0]);
            }

            // 2

            Console.WriteLine(
                SearchLongestWordStartingWithA("asdf as as asd asfasfasf asfasfasf")
            );

        }

        public static IEnumerable<Student> Filter(IEnumerable<Student> students)
        {
            return students.Where(s =>
            75 < s.Rating
            && (s.Subjects.Contains("Math") || s.Subjects.Contains("English"))
            ).ToList().Select(s => { s.Group = s.Group.ToUpper(); return s; });
        }

        public static string SearchLongestWordStartingWithA(string sentence)
        {
            /*
            return sentence
                .Split(' ')
                .OrderByDescending(s => s.Length)
                .Where(s => s.StartsWith('a'))
                .MaxBy(s => s.Length)??string.Empty;
                //.FirstOrDefault(s => s == 'a', "");
            */
            /*
            return sentence
                .Split(' ')
                .OrderByDescending(s => s.Length)
                .FirstOrDefault(s => true == s.StartsWith('a'), "");
            */

            return sentence
                .Split(' ')
                .Where(s => s.StartsWith('a'))
                .Aggregate("", (longest, next) => next.Length >= longest.Length ? next : longest);
        }
    }
}
