using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = IntMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = CharMax(first, second);
                Console.WriteLine(max);
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = StringMax(first, second);
                Console.WriteLine(max);
            }

        }
        static int IntMax(int first, int second)
        {
            int max = 0;

            if (first > second)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            return max;
        }
                   
        static char CharMax(char first, char second)
        {
            char max = (char)0x00;

            if (first > second)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            return max;
        }
        
        static string StringMax(string first, string second)
        {
            string max = "";

            if (first.CompareTo(second) > 0)
            {
                max = first;
            }
            else
            {
                max = second;
            }
            return max;
        }
    }
}
