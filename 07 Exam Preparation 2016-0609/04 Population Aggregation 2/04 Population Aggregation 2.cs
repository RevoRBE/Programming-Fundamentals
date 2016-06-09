using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Aggregation
{
    public class Population_Aggregation
    {
        public static void Main()
        {
            SortedDictionary<string, List<string>> citiesByCountry = new SortedDictionary<string, List<string>>();
            Dictionary<string, long> populationByCity = new Dictionary<string, long>();
            char[] prohibitedSymbols = "@#$&0123456789".ToCharArray();
            string input = "";

            while ((input = Console.ReadLine()) != "stop")
            {
                string[] data = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                long cityPopulation = long.Parse(data[2]);
                string country = data[0];
                string city = data[1];
                foreach (char symbol in prohibitedSymbols)
                {
                    country = country.Replace(symbol.ToString(), "");
                    city = city.Replace(symbol.ToString(), "");
                }
                if(char.IsLower(country[0]))
                {
                    string temp = country;
                    country = city;
                    city = temp;
                }
                if (!citiesByCountry.ContainsKey(country))
                    citiesByCountry[country] = new List<string>();
                citiesByCountry[country].Add(city);
                if (!populationByCity.ContainsKey(city))
                    populationByCity[city] = 0;
                populationByCity[city] = cityPopulation;
            }
            // country stats: country & number of cities
            foreach (var country in citiesByCountry)
                Console.WriteLine(string.Join(" -> ", country.Key, country.Value.Count()));
            // city stats: city & city population
            foreach (var city in populationByCity.OrderByDescending(x => x.Value).Take(3).ToList())
                Console.WriteLine(string.Join(" -> ", city.Key, city.Value));
        }
    }
}