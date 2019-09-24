using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int repet = 0;
            int mostFrNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int curNum = arr[i];
                int count = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (curNum == arr[j])
                    {
                        count++;
                    }
                }
                if (count > repet)
                {
                    mostFrNum = count;
                    repet = count;
                }
            }
            Console.WriteLine(mostFrNum);
        }
    }
}
