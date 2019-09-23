using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double lightsabersDisc = Math.Ceiling(0.10 * students);
            double totlightsabers = (students + lightsabersDisc) * lightsabers;

            double totRobes = robes * students;

            double freeBelts = Math.Floor(students / 6.00);
            double totBelts = belts * (students - freeBelts);

            double sum = totBelts + totlightsabers + totRobes;
            if (budget >= sum)
            {

                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                double result = sum - budget;
                Console.WriteLine($"Ivan Cho will need {result:f2}lv more.");
            }
        }
    }
}
