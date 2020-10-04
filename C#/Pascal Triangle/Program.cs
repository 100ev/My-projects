using System;

namespace Pascal_Triangle
{
    class Program
    {
        public static void PrintTriangle()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][];

            for (int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                triangle[i][0] = 1;
                triangle[i][triangle[i].Length - 1] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }
            }

            foreach (var arr in triangle)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PrintTriangle();
        }
    }
}
