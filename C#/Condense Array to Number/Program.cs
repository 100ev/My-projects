using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int[] arr2 = new int[arr.Length - 1];
                for (int j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = arr[j] + arr[j + 1];
                }

                arr = arr2;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
