using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquidsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ingredientssInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> ingredients = new Stack<int>(ingredientssInput);
            Dictionary<string, int> meals = new Dictionary<string, int>();

            meals.Add("Bread", 0);
            meals.Add("Cake", 0);
            meals.Add("Pastry", 0);
            meals.Add("Fruit Pie", 0);

            while (true)
            {
                if (ingredients.Count == 0 || liquids.Count == 0)
                {
                    break;
                }
                //if (liquids.Count == 0)
                //{
                //    break;
                //}
                if (liquids.Peek() + ingredients.Peek() == 25)
                {
                    meals["Bread"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else if (liquids.Peek() + ingredients.Peek() == 50)
                {
                    meals["Cake"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else  if (liquids.Peek() + ingredients.Peek() == 75)
                {
                    meals["Pastry"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else if (liquids.Peek() + ingredients.Peek() == 100)
                {
                    meals["Fruit Pie"]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                    continue;
                }
                else
                {
                    liquids.Dequeue();
                    var increasedIngredeint = ingredients.Pop() + 3;
                    ingredients.Push(increasedIngredeint);
                    continue;
                }
               
            }

            if (!meals.Values.Contains(0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            
            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var meal in meals.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{meal.Key}: {meal.Value}");
            }
        }
    }
}
