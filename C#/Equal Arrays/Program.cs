using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine("Arrays are not identical. Found difference at {0} index", i);
                    return;
                }
                else if (arr1.SequenceEqual(arr2))
                {
                    sum += arr1.Sum();
                    Console.WriteLine("arrays are identical.Sum: {0}", sum);
                    return;
                }
            }
        }
    }
}
