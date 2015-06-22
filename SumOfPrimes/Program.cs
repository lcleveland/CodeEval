using System;
namespace SumOfPrimes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sumOfPrimes = 129;
            int primeCount = 10;
            int currentNumber = 30;
            while (primeCount < 1000)
            {
                for (int i = 2; i < currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        break;
                    }
                    else if (i != currentNumber - 1)
                    {
                        continue;
                    }
                    primeCount++;
                    sumOfPrimes += currentNumber;
                }
                currentNumber++;
            }
            Console.Write(sumOfPrimes); 
        }
    }
}