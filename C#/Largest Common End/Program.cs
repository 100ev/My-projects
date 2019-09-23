using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int lgth = Math.Min(arr1.Length, arr2.Length);

            int leftLen = 0;

            for (int i = 0; i < lgth; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    leftLen++;
                }
                else
                {
                    break;
                }
            }

            arr1 = arr1.Reverse().ToArray();
            Array.Reverse(arr2);

            int rightLen = 0;
            for (int i = 0; i < lgth; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    rightLen++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftLen, rightLen));
        }
    }
}
