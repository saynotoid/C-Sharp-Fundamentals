using System.Collections.Generic;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_Task_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Please, implement the GetListOfPrimeNumbers method that returns
            // a list of prime numbers from the argument list.
            // 
            // All numbers in the result list should be unique,
            // duplicates should not be added to the result list.
            // 
            // The number is prime if its only dividers are 1 and this number itself.

            List<int> numbers = new List<int>()
            {
                { 16},
                { 8},
                { 24},
                { 7},
                { 8},
                { 8},
                { 21},
                { 8},
                { 6},
                { 17},
                { 20},
                { 11},
                { 13},
                { 16},
                { 28},
                { 27},
                { 7},
                { 11},
                { 30},
                { 16}
            };

            List<int> answer = GetListOfPrimeNumbers(numbers);

            foreach (var item in answer)
            {
                Console.WriteLine($"{item} ");
            }

            // Please, implement CreateCommonList method.
            // It takes Queue of strings as a first parameter and Stack of strings as a second.
            // The method should return a List of strings
            // that consists of elements from both collections
            // that do not belong to both collections simultaneously:

            Queue<string> queue = new(new[] { "ca", "bb", "b", "a", "c" });

            Stack<string> stack = new(new[] { "bc", "ca", "bb", "cc" });

            List<string> answer2 = CreateCommonList(queue, stack);


            foreach (var item in answer2)
            {
                Console.WriteLine($"{item} ");
            }

            // Please, implement FindValueByConditionOrDefault method
            // that returns the first value in a dictionary that satisfies a condition.
            // 
            // If there is no such value in the dictionary, the default value should be returned.
            // 
            // Keys of the dictionary should be int and values - any type
            // 
            // Arguments of the method:
            // 1. the dictionary
            // 2. condition
            // 3. the default value

            Dictionary<int, object> dictionary = new Dictionary<int, object>();

            //Console.WriteLine(FindValueByConditionOrDefault(dictionary, ,"default" ).ToString());

        }

        public static List<int> GetListOfPrimeNumbers(List<int> numbers)
        {
            List<int> numbersNoDupes = new HashSet<int>(numbers).ToList();
            numbersNoDupes.Sort();

            List<int> numbersNoDupesPrimes = new List<int>();

            // TODO add '2' case
            for (int i = 0; i < numbersNoDupes.Count; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < numbersNoDupes[i]; j++)
                {
                    if (numbersNoDupes[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    numbersNoDupesPrimes.Add(numbersNoDupes[i]);

            }

            return numbersNoDupesPrimes;
        }

        public static List<string> CreateCommonList(Queue<string> queue, Stack<string> stack)
        {
            List<string> answer = new List<string>();

            foreach (var item in queue)
            {
                if (stack.Contains(item))
                {

                }
                else
                {
                    answer.Add(item);
                }
            }

            foreach (var item in stack)
            {
                if (queue.Contains(item))
                {

                }
                else
                {
                    answer.Add(item);
                }
            }

            //answer.Sort();

            return answer;
        }

        public static T FindValueByConditionOrDefault<T>(Dictionary<int, T> dictionary, Func<T, bool> predicate, T defaultValue)
        {
            foreach (var item in dictionary)
            {
                if (predicate(item.Value))
                {
                    return item.Value;
                }
            }

            return defaultValue;
        }
    }
}
