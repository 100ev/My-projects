using System;
using System.Collections.Generic;
using System.Linq;

namespace Seashell_Treasure
{
    class Program
    {
        public static char[] seashels = new char[] { 'M', 'N', 'C' };
        public static int stolenSeashells = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] beach = new char[n][];
            List<char> collectedSeashells = new List<char>();

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().Split().Select(char.Parse).ToArray();
                beach[i] = row;
            }

            string command = "";
            while ((command = Console.ReadLine()) != "Sunset")
            {
                var tokens = command.Split();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (tokens[0] == "Collect")
                {
                    if (IsInMatrix(beach, row, col))
                    {
                        for (int i = 0; i < seashels.Length; i++)
                        {
                            if (beach[row][col] == seashels[i])
                            {
                                collectedSeashells.Add(seashels[i]);
                                beach[row][col] = '-';
                            }
                        }
                    }
                }
                if (tokens[0] == "Steal")
                {
                    Enemy(beach, row, col, tokens[3]);
                }
            }

            PrintMatrix(beach);
            Console.WriteLine("Collected seashells: {0}", collectedSeashells.Count());
            if (collectedSeashells.Any())
            {
                Console.WriteLine("-> " + string.Join(", ", collectedSeashells));
            }
            Console.WriteLine("Stolen seashells: {0}", stolenSeashells);
        }

        public static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsInMatrix(char[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
        }

        public static void Enemy(char[][] matrix, int row, int col, string direction)
        {
            if (IsInMatrix(matrix, row, col))
            {
                if (seashels.Contains(matrix[row][col]))
                {
                    matrix[row][col] = '-';
                    stolenSeashells++;
                    if (direction == "up")
                    {
                        for (int i = row; i >= row - 3; i--)
                        {
                            if (IsInMatrix(matrix, row - i, col) && seashels.Contains(matrix[i][col]))
                            {
                                stolenSeashells++;
                                matrix[i][col] = '-';
                            }
                        }
                    }
                    if (direction == "down")
                    {
                        for (int i = row; i <= row + 3; i++)
                        {
                            if (IsInMatrix(matrix, row + i, col) && seashels.Contains(matrix[i][col]))
                            {
                                stolenSeashells++;
                                matrix[i][col] = '-';
                            }
                        }
                    }
                    if (direction == "left")
                    {
                        for (int i = col; i >= col - 3; i--)
                        {
                            if (IsInMatrix(matrix, row, col - i) && seashels.Contains(matrix[row][i]))
                            {
                                stolenSeashells++;
                                matrix[row][i] = '-';
                            }
                        }
                    }
                }
            }
            if (direction == "right")
            {
                for (int i = col; i <= col + 3; i++)
                {
                    if (IsInMatrix(matrix, row, col + i) && seashels.Contains(matrix[row][i]))
                    {
                        stolenSeashells++;
                        matrix[row][i] = '-';
                    }
                }

            }
        }
    }
}
