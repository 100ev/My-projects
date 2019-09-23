using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int longestSequance = -1;
            int longestIndex = -1;
            int longestSum = -1;
            int[] seq = new int[length];
            int indexOfSeq = 1;
            int indexOfLongest = 0;
            string input = Console.ReadLine();

            while (input != "Clone them")
            {
                int[] curSequance = input.Split('!').Select(int.Parse).ToArray();
                int sequance = 0;
                int index = -1;
                int sum = 0;
                int count = 0;

                for (int i = 0; i < length; i++)
                {
                    if (curSequance[i] == 1)
                    {
                        count++;
                        sum++;
                        if (count > sequance)
                        {
                            sequance = count;
                            index = i - count;
                        }
                        count = 0;
                    }
                }

                if (sequance > longestSequance)
                {
                    longestIndex = index;
                    longestSequance = sequance;
                    longestSum = sum;
                    seq = curSequance;
                    indexOfLongest = indexOfSeq;
                }
                else if (sequance == longestSequance && longestIndex > index)
                {
                    longestIndex = index;
                    longestSequance = sequance;
                    longestSum = sum;
                    seq = curSequance;
                    indexOfLongest = indexOfSeq;
                }

                else if (sequance == longestSequance && longestIndex == index && longestSum < sum)
                {
                    longestSum = sum;
                    seq = curSequance;
                    indexOfLongest = indexOfSeq;
                }
                indexOfSeq++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {indexOfLongest} with sum: {longestSum}.");
            Console.WriteLine(String.Join(" ", seq));
        }
    }
}

