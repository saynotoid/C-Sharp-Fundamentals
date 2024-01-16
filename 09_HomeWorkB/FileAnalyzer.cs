using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09_HomeWorkB
{
    public static class FileAnalyzer
    {
        private static List<string> ReadFile()
        {
            List<string> strings = new List<string>();

            using (StreamReader sr = new StreamReader("client.test.js"))
            {
                while (!sr.EndOfStream)
                {
                    strings.Add(sr.ReadLine());
                }
            }

            return strings;
        }

        public static List<int> GetSumbolsCountInEachLine()
        {
            return ReadFile().Select(s => s.Length).ToList();
        }

        public static string GetLongestLine()
        {
            return ReadFile().MaxBy(s => s.Length);
            
            //return ReadFile().Aggregate((longest, next) => next.Length > longest.Length ? next : longest);

            //return ReadFile().OrderByDescending(s => s.Length).First();

            //return ReadFile()[GetSumbolsCountInEachLine().IndexOf(GetSumbolsCountInEachLine().Max())];
        }

        public static string GetShortestLine()
        {
            return ReadFile().MinBy(s => s.Length);

            //return ReadFile().Aggregate((shortest, next) => next.Length > shortest.Length ? shortest : next);

            //return ReadFile().OrderBy(s => s.Length).First();

            //return ReadFile()[GetSumbolsCountInEachLine().IndexOf(GetSumbolsCountInEachLine().Min())];
        }

        public static List<string> GetLinesWithLet()
        {
            return ReadFile().Where(s => Regex.Match(s, @"\s+let\s+").Success == true).ToList();

            //return ReadFile().Where(s => Regex.Match(s, @"^let$").Success == true).ToList();
        }
    }
}
