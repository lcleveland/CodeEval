using System;

namespace OddNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}