using System;
using System.IO;

namespace SwapNumbers
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
                    for (int i = 0; i < words.Length; i++)
                    {
                        char firstNum = words[i][0];
                        char lastNum = words[i][words[i].Length - 1];
                        Console.Write(lastNum + words[i].Substring(1, words[i].Length - 2) + firstNum);
                        if (i == words.Length - 1)
                        {
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("\n");
                }
        }
    }
}