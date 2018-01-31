using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] agrs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            nums.RemoveRange(agrs[0], nums.Count - agrs[0]);
            nums.RemoveRange(0, agrs[1]);
            foreach (var num in nums)
            {
                if (num == agrs[2])
                {
                    Console.WriteLine("YES!"); return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}