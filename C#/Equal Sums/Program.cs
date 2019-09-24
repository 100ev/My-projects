using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] leftSide = arr.Take(i).ToArray();
                int[] rigthSide = arr.Skip(i + 1).ToArray();
                if (leftSide.Sum() == rigthSide.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
