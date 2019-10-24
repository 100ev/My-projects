using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = SumOddsByEvens(n);
            Console.WriteLine(result);
        }

        static int SumOddsByEvens(int n)
        {
            int sumOdds = OddSum(n);
            int evenSum = EvenSum(n);
            return sumOdds * evenSum;
        }

        static int OddSum(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int digits = n % 10;
                n /= 10;
                if (digits % 2 != 0)
                {
                    sum += digits;
                }
            }
            return sum;
        }

        static int EvenSum(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                int digits = n % 10;
                n /= 10;
                if (digits % 2 == 0)
                {
                    sum += digits;
                }
            }
            return sum;
        }
    }
}
