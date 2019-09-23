using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int num = 0;
            int max = 0;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        num = nums[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
