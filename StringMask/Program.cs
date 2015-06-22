using System;
using System.IO;

namespace StringMask
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
                    var split = line.Split(' ');
                    var word = split[0];
                    var mask = split[1];
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (mask[i] == '1')
                        {
                            Console.Write(Char.ToUpper(word[i]));
                        }
                        else
                        {
                            Console.Write(Char.ToLower(word[i]));
                        }
                    }
                    Console.Write("\n");
                }
        }
    }
}