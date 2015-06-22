using System;
using System.IO;

namespace FibonacciSeries
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    int number = Int32.Parse(line);
                    if (number == 0 || number == 1)
                    {
                        Console.WriteLine(number);
                    }
                    else
                    {
                        int numberOne = 0;
                        int numberTwo = 1;
                        int sum = 0;
                        for (int i = 0; i < number; i++)
                        {
                            sum = numberOne + numberTwo;
                            numberTwo = numberOne;
                            numberOne = sum;
                        }
                        Console.WriteLine(sum);
                    }
                }
        }
    }
}