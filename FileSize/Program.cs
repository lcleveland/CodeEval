using System;
using System.IO;

namespace FileSize
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var file = File.Open(args[0], FileMode.Open))
            {
                Console.WriteLine(file.Length);
            }
        }
    }
}