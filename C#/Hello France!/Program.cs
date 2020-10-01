using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_France_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            double budget = double.Parse(Console.ReadLine());
            List<double> prices = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> data = input[i]
                    .Split("->")
                    .ToList();
                string item = data[0];
                double price = double.Parse(data[1]);

                if (item == "Clothes")
                {
                    if (price > 50)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= price;
                        price *= 1.4;
                        prices.Add(Math.Round(price, 2));
                    }
                }

                else if (item == "Shoes")
                {
                    if (price > 35)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= price;
                        price *= 1.4;
                        prices.Add(Math.Round(price, 2));
                    }
                }

                else if (item == "Accessories")
                {
                    if (price > 20.5)
                    {
                        continue;
                    }
                    else
                    {
                        budget -= price;
                        price *= 1.4;
                        prices.Add(Math.Round(price, 2));
                    }
                }

                if (budget < price)
                {
                    break;
                }
            }

            Console.Write(string.Join(" ", prices));
            Console.WriteLine();

            double totSum = 0;
            totSum += prices.Sum();
            double profit = totSum - totSum / 1.4;
            totSum += profit;

            Console.WriteLine($"Profit: {profit:f2}");

            if (totSum >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
