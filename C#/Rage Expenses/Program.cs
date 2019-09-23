using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headSet = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            int headsetCount = 0, mouseCount = 0, keyboardCount = 0, displayCount = 0;
            int displays = 0;
            double price = 0;

            for (int i = 1; i <= games; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;

                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        displays = 1;
                    }

                }

                if (keyboardCount % 2 == 0 && displays == 1)
                {
                    displayCount++;
                    displays = 0;
                }
            }
            price = (headsetCount * headSet) + (mouseCount * mouse) + (keyboardCount * keyboard) + (displayCount * display);

            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}
