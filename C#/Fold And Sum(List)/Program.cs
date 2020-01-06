using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_And_Sum_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int quater = num.Count / 4;

            var folded = num.Skip(quater * 3).Reverse().ToList();
            folded = new List<int>(num.Take(quater).Reverse().ToList().Concat(folded));
            num = num.Skip(quater).Take(quater * 2).ToList();

            var res = new List<int>();
            for (int i = 0; i < quater * 2; i++)
            {
                res.Add(num[i] + folded[i]);
            }

            Console.WriteLine(String.Join(" ", res));
        }
    }
}
