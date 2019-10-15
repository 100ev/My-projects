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
            Checker(input);
        }
        static void Checker(string input)
        {
            switch (input)
            {
                case ("int"):
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int max = 0;

                    if (num1 > num2)
                    {
                        max = num1;
                    }
                    else
                    {
                        max = num2;
                    }
                    Console.WriteLine(max);
                    break;
                case ("char"):
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    char maxChar = (char)0x00;

                    if (ch1 > ch2)
                    {
                        maxChar = ch1;
                    }
                    else
                    {
                        maxChar = ch2;
                    }
                    Console.WriteLine(maxChar);
                    break;
                case ("string"):
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    string maxString = "";

                    if (first.CompareTo(second) > 0)
                    {
                        maxString = first;
                    }
                    else
                    {
                        maxString = second;
                    }
                    Console.WriteLine(maxString);
                    break;
            }
        }
    }
}
