using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Rainer
    {
        static void Main(string[] args)
        {
            var origArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rain = new int[origArr.Length - 1];
            Array.Copy(origArr, rain, origArr.Length - 1);
            var donald = origArr.Last();
            int steps = 0;
            while (true)
            {
                rain = Array.ConvertAll(rain, i => i-1);
                if (rain[donald] == 0) break;
                for (int i = 0; i < rain.Length; i++)
                {
                    if (rain[i] == 0) rain[i] = origArr[i];
                }
                steps++;
                donald = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(",", rain));
            Console.WriteLine(steps);
        }
    }
}
