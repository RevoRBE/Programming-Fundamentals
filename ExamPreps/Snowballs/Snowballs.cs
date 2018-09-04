using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snowballs
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var saved = new List<double>();
            BigInteger biggest = 0;

            for (double i = 0; i < n; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger temp = BigInteger.Pow((BigInteger)(snowballSnow / snowballTime), snowballQuality);
                if (temp > biggest)
                {
                    biggest = temp;
                    double snowballValue = (double)temp;
                    saved.Clear();
                    saved.Add(snowballSnow);
                    saved.Add(snowballTime);
                    saved.Add(snowballQuality);
                }
            }
            Console.WriteLine($"{saved[0]} : {saved[1]} = {biggest} ({saved[2]})");
        }
    }
}
