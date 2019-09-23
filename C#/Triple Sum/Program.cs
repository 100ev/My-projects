using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool count = TriplesSum(nums);
            if (!count)
            {
                Console.WriteLine("No");
            }
        }
        static bool TriplesSum(int[] nums)
        {
            bool triples = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (nums.Contains(sum))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[j]} == {sum}");
                        triples = true;
                    }
                }
            }
            return triples;
        }
    }
}
