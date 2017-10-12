using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_CenterPodouble
{
    class Program
    {
        private static double GetDistance(double x, double y)
        {
            return Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double dist1 = GetDistance(x1, y1);
            double dist2 = GetDistance(x2, y2);
            bool oneCloser = dist1 < dist2;
            Console.WriteLine("({0}, {1})",oneCloser?x1:x2,oneCloser?y1:y2);
        }
    }
}