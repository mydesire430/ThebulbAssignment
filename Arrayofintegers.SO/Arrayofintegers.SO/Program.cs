namespace Arrayofintegers.SO
{
    internal class Program
    {
        static void Main()
        {
            int[] myNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var result = ProcessArray(myNum);
            Console.WriteLine("Prime count: " + result.PrimeCount);
            Console.WriteLine("Even count: " + result.EvenCount);
            Console.WriteLine("Odd count: " + result.oddCount);
            Console.WriteLine("Sum of Primes: " + result.SumOfPrimes);
            Console.WriteLine("Sum of Evens: " + result.SumOfEven);
            Console.WriteLine("Sum of Odds: " + result.SumOfOddss);
        }
        public static (int PrimeCount, int EvenCount, int oddCount, int SumOfPrimes, int SumOfEven, int SumOfOddss)
          ProcessArray(int[] myNum)

        {
            int primeCount = 0;
            int evenCount = 0;
            int oddCount = 0;
            int sumOfPrimes = 0;
            int sumOfEvens = 0;
            int sumOfOdds = 0;
            foreach (var number in myNum)
            {
                if (IsPrime(number))
                {
                    primeCount++;
                    sumOfPrimes += number;
                }
                if (number % 2 == 0)
                {
                    evenCount++;
                    sumOfEvens += number;
                }
                else
                {
                    oddCount++;
                    sumOfOdds += number;
                }
            }
            return (primeCount, evenCount, oddCount, sumOfPrimes, sumOfEvens, sumOfOdds);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

    }
}
