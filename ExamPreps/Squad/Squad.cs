using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squad
{
    class Squad
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> leaders = new Dictionary<string, HashSet<string>>();
            List<string> check = new List<string>();
            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                string[] data = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string leader = data[0];
                string squadMate = data[1];
                check.Add(squadMate + "" + leader);
                if (!leaders.ContainsKey(leader))
                {
                    leaders.Add(leader, new HashSet<string>());
                }
                if (leader == squadMate || check.Contains(leader+ "" +squadMate))
                {
                    leaders[squadMate].Remove(leader);
                    input = Console.ReadLine();
                    continue;
                }
                leaders[leader].Add(squadMate);

                input = Console.ReadLine();
            }
            foreach (var item in leaders.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
