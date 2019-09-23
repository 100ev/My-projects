using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;

            int[] leftArr = nums.Take(k).ToArray();
            int[] midArr = nums.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = nums.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            rightArr = rightArr.Reverse().ToArray();
            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = midArr[i] + leftArr[i];
                result[i + k] = midArr[i + k] + rightArr[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
