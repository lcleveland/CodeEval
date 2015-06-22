using System;
using System.IO;

namespace FindAWriter
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
                    var sections = line.Split('|');
                    var letters = sections[0].ToCharArray();
                    var codeNumbers = sections[1].Split(' ');
                    for (int i = 1; i < codeNumbers.Length; i++)
                    {
                        int index = 0;
                        if (int.TryParse(codeNumbers[i], out index))
                        {
                            Console.Write(letters[index - 1]);
                        }
                    }
                    Console.Write("\n");
                }
        }
    }
}