using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Pokemon_Evolution
{
    public class Evolution
    {
        public string Type { get; set; }
        public long Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pokemons = new Dictionary<string, List<Evolution>>();
            while (input != "wubbalubbadubdub")
            {
                var data = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (data.Count > 1)
                {
                    var name = data[0];
                    var type = data[1];
                    var index = long.Parse(data[2]);
                    var evo = new Evolution() { Type = type, Value = index };
                    if (!pokemons.ContainsKey(name))
                    {
                        pokemons.Add(name, new List<Evolution>());
                        pokemons[name].Add(evo);
                    }
                    else pokemons[name].Add(evo);
                }
                else
                {
                    var pokemon = input;
                    if (pokemons.ContainsKey(pokemon))
                    {
                        Console.WriteLine($"# {pokemon}");
                        foreach (var evo in pokemons[pokemon])
                        Console.WriteLine($"{evo.Type} <-> {evo.Value}");
                    }
                    //foreach (var item in pokemons)
                    //    if (item.Key == pokemon)
                    //    {
                    //        Console.WriteLine($"# {item.Key}");
                    //        foreach (var evos in item.Value)
                    //            Console.WriteLine($"{evos.Type} <-> {evos.Index}");
                    //    }
                }
                input = Console.ReadLine();
            }
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evos in pokemon.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{evos.Type} <-> {evos.Value}");
                }
            }
        }
    }
}