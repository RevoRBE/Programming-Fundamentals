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

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop") break;            
                string[] data = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                long cityPopulation = long.Parse(data[2]);
                string country = data[0];
                string city = data[1];
                country = RemoveInvalidChars(country);
                city = RemoveInvalidChars(city);
                if (char.IsLower(country[0]))
                {
                    string temp = country;
                    country = city;
                    city = temp;
                }
                if (!citiesByCountry.ContainsKey(country))
                    citiesByCountry[country] = new List<string>();
                citiesByCountry[country].Add(city);
                populationByCity[city] = cityPopulation;
            }
            PrintStats(citiesByCountry, populationByCity);
        }

        private static void PrintStats(SortedDictionary<string, List<string>> citiesByCountry, Dictionary<string, long> populationByCity)
        {
            foreach (var country in citiesByCountry)
                Console.WriteLine(string.Join(" -> ", country.Key, country.Value.Count())); // country & count cities
            foreach (var city in populationByCity.OrderByDescending(x => x.Value).Take(3).ToList())
                Console.WriteLine(string.Join(" -> ", city.Key, city.Value));               // largest 3 cities & city population
        }

        private static string RemoveInvalidChars(string text)
        {
            string[] validChars = text.Split("@#$&0123456789".ToCharArray());
            return string.Join("", validChars);
        }
    }
}