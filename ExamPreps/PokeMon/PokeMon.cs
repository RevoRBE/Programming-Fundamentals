using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double norig = n;
            byte y = byte.Parse(Console.ReadLine());
            int c = 0;
            while (n>=m)
            {
                if (norig / 2 == n && y!=0)
                {
                    n /= y;
                    if (n<m)
                    {
                        continue;
                    }
                }
                n -= m;
                c++;
            }
            Console.WriteLine($"{n}\n{c}");
        }
    }
}
