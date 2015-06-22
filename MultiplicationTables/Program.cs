using System;

namespace MultiplicationTables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] table = new int[12, 12];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int a = 0; a < table.GetLength(1); a++)
                {
                    Console.Write("{0, 4}", ((i + 1) * (a + 1)));
                    if (a == table.GetLength(1) - 1)
                    {
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}