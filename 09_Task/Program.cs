namespace _09_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a collection(array) of 10 integers numbers
            // 
            // Get and display only negative numbers on the console
            // 
            // Get and display only positive numbers on the console
            // 
            // Get the largest and smallest elements from the array,
            // and find the sum of all elements of the array.
            //
            // Get the first largest element in array that is smaller than the Average of elements in array
            //
            // Sort the array using OrderBy

            //IEnumerable<int> ints = Enumerable.Range(-5, 11);
            
            IEnumerable<int> ints = new int[] { -10, 1, 2, 3, -7 };

            Positives(ints);

            Negatives(ints);

            MaxMinSum(ints);

            FirstMaxThatIsLessThanAvg(ints);

            IntsOrderBy(ints);
        }

        public static void Negatives(IEnumerable<int> ints)
        {
            IEnumerable<int> negatives = from num in ints
                                         where num < 0
                                         select num;

            foreach (int num in negatives)
            {
                Console.WriteLine(num);
            }
        }

        public static void Positives(IEnumerable<int> ints)
        {
            IEnumerable<int> negatives = from num in ints
                                         where 0 < num
                                         select num;

            foreach (int num in negatives)
            {
                Console.WriteLine(num);
            }
        }

        public static void MaxMinSum(IEnumerable<int> ints)
        {
            Console.WriteLine($"Max: {ints.Max()}");
            Console.WriteLine($"Min: {ints.Min()}");
            Console.WriteLine($"Sum: {ints.Sum()}");
        }

        public static void FirstMaxThatIsLessThanAvg(IEnumerable<int> ints)
        {
            /*
            IEnumerable<int> num2 = from num in ints
                                    where num < ints.Average()
                                    select num;
            */

            // array of < Average
            //IEnumerable<int> num2 = ints.Where(num => num < ints.Average());

            // max of < Average
            //num2.Max();

            // first of ints that is max of < Average
            //Console.WriteLine($"FMTILTA: {ints.First(num => num == num2.Max())}");

            // Concatenated line

            Console.WriteLine($"FMTILTA: " +
                $"{ints.First(num => num == ints.Where(num => num < ints.Average()).Max())}");

            //foreach (int num in num2)
            //{
            //    Console.WriteLine($"test: {num}");
            //}
        }

        public static void IntsOrderBy(IEnumerable<int> ints)
        {
            Console.WriteLine($"Ordered by: {ints = ints.OrderBy(i => i)}");

            foreach (int num in ints)
            {
                Console.WriteLine($"{num}");
            }
        }
    }
}
