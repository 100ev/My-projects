using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> privateMassagesList = new List<string>();
            List<string> broadCastList = new List<string>();

            while (input != "Hornet is Green")
            {
                string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.None);
                
                if (tokens.Length != 2)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string firstQuery = tokens[0];
                string secondQuery = tokens[1];

                bool isItaNumber = Regex.IsMatch(firstQuery, @"[0-9]");
                bool checkIfOnlyLettersAndDigits = isItJustLetterOrDigits(secondQuery);

                if (isItaNumber && checkIfOnlyLettersAndDigits)
                {
                    firstQuery = Reverse(firstQuery);
                    string enterToList = firstQuery + " -> " + secondQuery;
                    privateMassagesList.Add(enterToList);
                }

                if (!isItaNumber && checkIfOnlyLettersAndDigits)
                {
                    secondQuery = ChangeLetterSizesInString(secondQuery);
                    string enterToList1 = secondQuery + " -> " + firstQuery;
                    broadCastList.Add(enterToList1);
                }


                input = Console.ReadLine();
            }
            
            Console.WriteLine("Broadcasts:");

            if (broadCastList.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadCastList)
                {
                    Console.WriteLine(item);
                }
            }


            Console.WriteLine("Messages:");

            if (privateMassagesList.Count == 0)
            {
                Console.WriteLine("None");

            }
            else
            {
                foreach (var item in privateMassagesList)
                {
                    Console.WriteLine(item);
                }
            }


        }

        private static bool isItJustLetterOrDigits(string secondQuery)
        {
            bool isitValid = true;
            for (int i = 0; i < secondQuery.Length; i++)
            {
                if (!char.IsLetterOrDigit(secondQuery[i]))
                {
                    isitValid = false;
                    break;
                }
            }
            return isitValid;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string ChangeLetterSizesInString(string secondQuery)
        {
            string newString = "";

            for (int i = 0; i < secondQuery.Length; i++)
            {
                if (char.IsLower(secondQuery[i]))
                {
                    newString += char.ToUpper(secondQuery[i]);
                }
                else if (char.IsUpper(secondQuery[i]))
                {
                    newString += char.ToLower(secondQuery[i]);
                }
                else
                {
                    newString += secondQuery[i];
                }
            }
            return newString;
        }

    }
}

