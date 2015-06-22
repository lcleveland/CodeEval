using System;
using System.IO;

namespace RightmostChar
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
                    var strings = line.Split(',');
                    Console.WriteLine(strings[0].LastIndexOf(strings[1]));
                }
        }
    }
}