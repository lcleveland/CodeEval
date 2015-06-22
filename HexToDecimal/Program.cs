using System;
using System.IO;

namespace HexToDecimal
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
                    Console.WriteLine(Convert.ToInt64(line, 16));
                }
        }
    }
}