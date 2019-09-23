using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Of_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (input[i].ToString().Contains(letter[j]))
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
