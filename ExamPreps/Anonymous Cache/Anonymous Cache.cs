using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataSetList = new List<string>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                var data = input.Split("->| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (data.Length == 1 && !dataSetList.Contains(input)) dataSetList.Add(input);
                else
                {
                    string dataSet = data[2];
                    string dataKey = data[0];
                    long dataSize = long.Parse(data[1]);
                    if (!cache.ContainsKey(dataSet)) cache.Add(dataSet, new Dictionary<string, long>());
                    cache[dataSet][dataKey] = dataSize;
                    //cache[dataSet].Add(dataKey, dataSize);
                }
                input = Console.ReadLine();
            }

            cache.ToList().Where(e => dataSetList.Contains(e.Key)).ToList().Where(e => dataSetList.Remove(e.Key));//CLEAR THE CACHE OF UNUSED DATASET

            if (dataSetList.Count > 0)
            {
                var result = cache.OrderByDescending(x => x.Value.Sum(s => s.Value)).First();
                //WHILE if (!dataSetList.Contains(result.Key)) cache.Remove(result.Key);                      //CLEAR THE CACHE OF UNUSED DATASET
                //else DO BREAK

                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(s => s.Value)}");
                foreach (var item in result.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
