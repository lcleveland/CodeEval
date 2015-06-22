using System;
using System.IO;

namespace QueryBoard
{
    internal class Program
    {
        private static int[,] board = new int[256, 256];

        private static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    var message = line.Split(' ');
                    string command = null;
                    int index = 0;
                    int value = 0;
                    command = message[0];
                    index = int.Parse(message[1]);
                    if (message.Length == 3)
                    {
                        value = int.Parse(message[2]);
                    }
                    switch (command)
                    {
                        case "SetCol":
                            SetCol(index, value);
                            break;

                        case "SetRow":
                            SetRow(index, value);
                            break;

                        case "QueryCol":
                            QueryCol(index);
                            break;

                        case "QueryRow":
                            QueryRow(index);
                            break;
                    }
                }
        }

        private static void SetRow(int index, int value)
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                board[index, i] = value;
            }
        }

        private static void SetCol(int index, int value)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[i, index] = value;
            }
        }

        private static void QueryRow(int index)
        {
            int sum = 0;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                sum += board[index, i];
            }
            Console.WriteLine(sum);
        }

        private static void QueryCol(int index)
        {
            int sum = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                sum += board[i, index];
            }
            Console.WriteLine(sum);
        }
    }
}