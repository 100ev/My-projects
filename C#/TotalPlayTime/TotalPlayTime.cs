using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TotalPlayTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int minSum = 0;
            int secSum = 0;

            int h = 0;


            while (input != "Play")
            {

                var arr = input.Split(':').ToArray();

                int min = int.Parse(arr[0]);
                int sec = int.Parse(arr[1]);

                minSum += min;
                secSum += sec;

                if (secSum > 59)
                {
                    secSum -= 60;
                    minSum++;
                }
                if (minSum > 59)
                {
                    minSum -= 60;
                    h++;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total Time -> {h}:{minSum:D2}:{secSum:D2}");
        }
    }
}