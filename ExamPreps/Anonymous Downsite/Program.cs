using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int key = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            BigInteger secToken = BigInteger.Pow(key, n);
            var siteList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                //{siteName} {siteVisits} {siteCommercialPricePerVisit}
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                decimal siteVisits = decimal.Parse(tokens[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(tokens[2]);
                siteList.Add(tokens[0]);
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(siteList[i]);
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {secToken}");
        }
    }
}
