using System;
using System.IO;

namespace PenultimateWord
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
                    var words = line.Split(' ');
                    Console.WriteLine(words[words.Length - 2]);
                }
        }
    }
}