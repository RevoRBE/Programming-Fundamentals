using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Snowmen
    {
        static void Main(string[] args)
        {
            string war = Console.ReadLine();
            List<int> arena = war.Split().Select(int.Parse).ToList();
            List<int> fallen = new List<int>();

            while (arena.Count > 1)
            {
                for (int attacker = 0; attacker < arena.Count; attacker++)
                {
                    if (!fallen.Contains(attacker))
                    {
                        int target = arena[attacker];
                        if (target >= arena.Count) target = target % arena.Count;
                        var result = Math.Abs(attacker - target);
                        if (attacker == target)
                        {
                            Console.WriteLine($"{attacker} performed harakiri");
                            fallen.Add(attacker);
                        }
                        else if (result % 2 == 0)
                        {
                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                            fallen.Add(target);
                        }
                        else
                        {
                            Console.WriteLine($"{attacker} x {target} -> {target} wins");
                            fallen.Add(attacker);
                        }
                        if (fallen.Distinct().ToList().Count + 1 == arena.Count)
                        {
                            return;
                        }
                    }
                }
                fallen.Sort();
                fallen.Reverse();
                fallen = fallen.Distinct().ToList();
                arena.RemoveAll(x => fallen.Contains(arena.IndexOf(x)));
                //foreach (var killed in fallen.Distinct().OrderByDescending(x => x))
                //    arena.RemoveAt(killed);
                fallen.Clear();
            }
        }
    }
}