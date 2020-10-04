using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        public static int FindDifference(int n, int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int primary = 0;
            int secondary = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primary += matrix[i, i];
                secondary += matrix[i, matrix.GetLength(1) - i - 1];
            }

            return Math.Abs(primary - secondary);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int result = FindDifference(n, matrix);
            Console.WriteLine(result);
        }
    }
}
