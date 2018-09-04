using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoekmonEvol
{
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> pokemons = new Dictionary<string, Dictionary<string, int>>();

            while (input != "wubbalubbadubdub")
            {

                string[] data = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (data.Length > 2)
                {
                    //string name = data[0];
                    //string eType = data[1];
                    //int eIndex = int.Parse(data[2]);
                    //if (!pokemons.ContainsKey(name))
                    //    pokemons.Add(name, new Dictionary<string, int>());
                    //pokemons[name][eType] = eIndex}");
                }
                else if (data.Length < 2)
                {
                    string name = input;

                    if (pokemons.ContainsKey(name))
                        foreach (var ev in pokemons[name])
                            Console.WriteLine(ev);
                }
                input = Console.ReadLine();
            }
            foreach (var item in pokemons.OrderByDescending(x => pokemons[x.Key].Sum(e => e.Value)).ThenBy(k => k.Value.Count))
            {
                Console.WriteLine($"Train: {item.Key}");
                foreach (var inner in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{inner.Key} - {inner.Value}");
                }
            }
        }
    }
}
