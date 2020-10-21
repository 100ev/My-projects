using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray().Select(ch => (int)ch).Sum() >= num;
            Func<string[], int, Func<string, int, bool>, string> firtsValidName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

            var result = firtsValidName(names, number, isValidWord);
            Console.WriteLine(result);
        }
    }
}
