using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();
            if (numbers.Length == 1) { Console.WriteLine(0); return; }
            for (int i = 0; i < numbers.Length; i++)
                if (numbers.Take(i).ToArray().Sum() == numbers.Skip(i + 1).Take(numbers.Length - i + 1).ToArray().Sum())
                {
                    Console.WriteLine(i);
                    return;
                }
            Console.WriteLine("no");
        }
    }
}
