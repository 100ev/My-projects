using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            long fact = num;
            long sum = 0;

            while (num != 0)
            {
                long result = fact % 10;
                fact /= 10;

                long factorial = 1;
                for (int i = 1; i <= result; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

