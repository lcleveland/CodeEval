using System;
using System.IO;

namespace FizzBuzz
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
                    int firstDivisor;
                    int secondDivisor;
                    int upperNumber;
                    var values = line.Split(' ');
                    firstDivisor = Int32.Parse(values[0]);
                    secondDivisor = Int32.Parse(values[1]);
                    upperNumber = Int32.Parse(values[2]);
                    for (int i = 1; i <= upperNumber; i++)
                    {
                        if (i % firstDivisor == 0 && i % secondDivisor == 0)
                        {
                            Console.Write("FB");
                        }
                        else if (i % firstDivisor == 0)
                        {
                            Console.Write("F");
                        }
                        else if (i % secondDivisor == 0)
                        {
                            Console.Write("B");
                        }
                        else
                        {
                            Console.Write(i);
                        }
                        if (i == upperNumber)
                        {
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
        }
    }
}