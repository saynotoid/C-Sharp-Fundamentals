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
    }
}
