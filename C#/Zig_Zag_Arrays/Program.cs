using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < input.Length - 1; j++)
                {
                    secondArr[i] = input[j];
                    firstArr[i] = input[j + 1];
                }
            }

            for (int i = 0; i < n; i += 2)
            {
                int swap = 0;
                swap = secondArr[i];
                secondArr[i] = firstArr[i];
                firstArr[i] = swap;
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}
