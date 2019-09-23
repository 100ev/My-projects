using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxLen = 1;
            int maxStart = 0;
            int curLen = 1;
            int curStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    curLen++;

                    if (curLen > maxLen)
                    {
                        maxLen = curLen;
                        maxStart = curStart;
                    }
                }
                else
                {
                    curLen = 1;
                    curStart = i;
                }
            }

            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
