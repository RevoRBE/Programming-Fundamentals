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
            List<int> arena = war.Split().Select(x => int.Parse(x)).ToList();
            int attacker = 0;
            List<int> fallen = new List<int>();
            var area = arena.Count;

            while (true)
            {
                int target = arena[attacker];
                if (target > arena.Count) target = target % arena.Count;
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
                else if (result % 2 != 0)
                {
                    Console.WriteLine($"{attacker} x {target} -> {target} wins");
                    fallen.Add(attacker);
                }
                if (fallen.Count+1 == area)
                {
                    break;
                }
                attacker++;
                while (fallen.Contains(attacker))
                {
                    attacker++;
                }
                if (attacker > arena.Count - 1)
                {
                    attacker = 0;
                    fallen.Distinct();
                    arena.RemoveAll(x => fallen.Contains(arena.IndexOf(x)));
                }
            }
        }
    }
}
