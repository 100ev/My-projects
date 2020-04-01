using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int snowBall = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;

            BigInteger maxValue = 0;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                snowBall = int.Parse(Console.ReadLine());
                snowBallTime = int.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowBall / snowBallTime), snowBallQuality);
                if (value >= maxValue)
                {
                    maxValue = value;
                    result = ($"{snowBall} : {snowBallTime} = {maxValue} ({snowBallQuality})");
                }
            }
            Console.WriteLine(result);
        }
    }
}
