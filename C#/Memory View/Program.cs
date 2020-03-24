using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string items = string.Empty;
            List<string> words = new List<string>();

            while (input != "Visual Studio crash")
            {
                items += input + " ";
                input = Console.ReadLine();
            }

            string[] data = items.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "32656" && data[i + 1] == "19759" && data[i + 2] == "32763" && data[i + 3] == "0" && data[i + 5] == "0")
                {
                    string word = string.Empty;
                    int wordLength = int.Parse(data[i + 4]);
                    int start = i + 6;
                    for (int j = start; j <= start + wordLength; j++)
                    {
                        word += (char)(int.Parse(data[j]));
                    }
                    words.Add(word);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
