using System;
using System.IO;
using System.Linq;

namespace SumOfDigits
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
                    int sum = 0;
                    foreach (var digit in line.ToArray())
                    {
                        sum += (int)Char.GetNumericValue(digit);
                    }
                    Console.WriteLine(sum);
                }
        }
    }
}