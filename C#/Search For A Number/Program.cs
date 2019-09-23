using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_For_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] search = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> takenNums = new List<int>();
            takenNums = input;

            for (int i = 0; i < search[0]; i++)
            {
                while (search[1] > 0)
                {
                    search[1]--;
                    takenNums.RemoveAt(0);
                }
            }

            if (takenNums.Contains(search[2]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
