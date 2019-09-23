using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> items = input.Split(' ').ToList();
            List<int> result = new List<int>();

            foreach (var item in items)
            {
                int num = int.Parse(item);
                double root = Math.Sqrt(num);
                double rootAsInt = (int)root;
                if (root == rootAsInt)
                {
                    result.Add(num);
                }
            }

            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
