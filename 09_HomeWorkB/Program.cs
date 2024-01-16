using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace _09_HomeWorkB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // B) Create Console Application project.
            // Prepare txt file with a lot of text inside
            // (for example take you.cs file from previous homework)
            // 
            // Read all lines of text from file into array of strings.
            // Each array item contains one line from file.
            // 
            // Complete next tasks:
            // 1) Count and write the number of symbols in every line.
            // 2) Find the longest and the shortest line.
            // 3) Find and write only lines, which consist of word "var"

            List<string> strings = new List<string>();

            using (StreamReader sr = new StreamReader("Program.cs"))
            {
                while (!sr.EndOfStream)
                {
                    strings.Add(sr.ReadLine());
                }
            }

            // 1) Count and write the number of symbols in every line.

            foreach (string s in strings)
            {
                Console.WriteLine($"The number of symbols in line -> {Regex.Replace(s, @"\s+", "").Length}");
            }

            // 2) Find the longest and the shortest line.

            Console.WriteLine($"The longest line is " +
                $"{strings.Select(s => Regex.Replace(s, @"\s+", "").Length.ToString()).ToList().Max()}");

            Console.WriteLine($"The longest line is " +
                $"{strings.Select(s => Regex.Replace(s, @"\s+", "").Length.ToString()).ToList().Min()}");

            // 3) Find and write only lines, which consist of word "var"

            foreach (string s in strings.Where(s => Regex.Match(s, @"^var$").Success == true).ToList())
            {
                Console.WriteLine(s);
            }
        }
    }
}
