using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr1.Length >= arr2.Length)
            {
                var maxArr = arr1.Length;
                for (int i = 0; i <= arr1.Length; i++)
                {
                    maxArr = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i > arr1.Length)
                    {
                        break;
                    }
                    Console.Write(maxArr + " ");
                }
            }
            else
            {
                var maxArr = arr2.Length;
                for (int i = 0; i <= arr2.Length; i++)
                {
                    maxArr = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                    if (i > arr2.Length)
                    {
                        break;
                    }
                }
                Console.Write(maxArr + " ");
            }
        }
    }
}
