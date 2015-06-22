using System;
using System.IO;

namespace ReverseWords
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
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        Console.Write(words[i]);
                        if (i != 0)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
        }
    }
}