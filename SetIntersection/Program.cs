using System;
using System.IO;
using System.Linq;

namespace SetIntersection
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
                    var lists = line.Split(';');
                    var listOne = lists[0].Split(',');
                    var listTwo = lists[1].Split(',');
                    var matches = listOne.Intersect(listTwo).ToArray();
                    if (matches.Length == 0)
                    {
                        Console.Write("\n");
                    }
                    else
                    {
                        for (int i = 0; i < matches.Length; i++)
                        {
                            Console.Write(matches[i]);
                            if (i == matches.Length - 1)
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
}