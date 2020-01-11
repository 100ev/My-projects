using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {

                string[] par = input.Split('|');
                string city = par[0];
                string country = par[1];
                long pop = long.Parse(par[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                }
                if (!countries[country].ContainsKey(city))
                {
                    countries[country].Add(city, 0);
                }
                countries[country][city] += pop;

                input = Console.ReadLine();
            }

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=> {city.Key} : {city.Value}");
                }
            }
        }
    }
}
