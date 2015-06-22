using System;
using System.IO;

namespace SumOfIntegersFromFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sum = 0;
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    sum += Int32.Parse(line);
                }
            Console.WriteLine(sum);
        }
    }
}