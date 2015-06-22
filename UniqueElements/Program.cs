using System;
using System.IO;
using System.Linq;

namespace UniqueElements
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
                    var nonduplicate = numbers.Distinct().ToArray();
                    for (int i = 0; i < nonduplicate.Length; i++)
                    {
                        Console.Write(nonduplicate[i]);
                        if (i == nonduplicate.Length - 1)
                        {
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write(",");
                        }
                    }
                }
        }
    }
}