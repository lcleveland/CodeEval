using System;
using System.Collections.Generic;
using System.IO;

namespace SimpleSorting
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
                    var numbersString = line.Split(' ');
                    List<float> numbersList = new List<float>();
                    foreach (var number in numbersString)
                    {
                        numbersList.Add(float.Parse(number));
                    }
                    numbersList.Sort();
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        Console.Write("{0:F3}", numbersList[i]);
                        if (i == numbersList.Count - 1)
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