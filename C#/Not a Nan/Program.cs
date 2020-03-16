using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_a_Nan
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            string phrase = "";
            string totResult = string.Empty;
            
            if (times == 0)
            {
                Console.WriteLine(phrase);
            }
            else if (times == 1)
            {
                Console.WriteLine("Not a Nan");
            }
            else
            {

                for (int i = 1; i < times; i++)
                {
                    phrase = "Not a ";
                    Console.Write(phrase);
                    totResult = String.Concat(phrase, "NaN");
                }
                Console.WriteLine(totResult);
            }
        }
    }
}
