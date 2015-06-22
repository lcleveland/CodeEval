using System;
using System.IO;

namespace MultiplesOfANumber
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
                    var numbers = line.Split(',');
                    int numberOne = Int32.Parse(numbers[0]);
                    int numberTwo = Int32.Parse(numbers[1]);
                    int temp = numberTwo;
                    while (numberTwo < numberOne)
                    {
                        numberTwo += temp;
                    }
                    Console.WriteLine(numberTwo);
                }
        }
    }
}