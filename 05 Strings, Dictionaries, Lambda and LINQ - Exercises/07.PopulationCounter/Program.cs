using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            Dictionary<string, Dictionary<string, long>> register = new Dictionary<string, Dictionary<string, long>>();

            while (input[0] != "report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);
                Dictionary<string, long> cities = new Dictionary<string, long>();

                if (!register.ContainsKey(country))
                {
                    cities[city] = population;
                    register.Add(country, cities);
                }
                else
                {
                    cities = register[country];
                    if (cities.ContainsKey(city))
                    {
                        cities[city] += population;
                    }
                    else
                    {
                        cities.Add(city, population);
                        register[country] = cities;
                    }
                }
                input = Console.ReadLine().Split('|').ToArray();
            }
            foreach (var state in register.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
