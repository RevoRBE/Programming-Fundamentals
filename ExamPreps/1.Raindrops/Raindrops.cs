using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Raindrops
{
    class Raindrops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            List<double> regionalCoefficients = new List<double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
                var raindropsCount = input[0];
                var squareMeters = input[1];
                regionalCoefficients.Add(raindropsCount / squareMeters);
            }
            double sum = regionalCoefficients.Sum();
            if (density == 0) Console.WriteLine($"{sum:F3}");
            else Console.WriteLine($"{sum/density:F3}");
        }
    }
}
