using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            string pattern = @"[^A-Za-z\d]+[\d_]+[\D^A-Za-z]+[\d_]+([A-Za-z]+)[\d_]+[\D^A-Za-z]+[\d_]+[^A-Za-z\d]+$";
            string flake = "";

            for (int i = 0; i < 5; i++)
            {
                flake += Console.ReadLine();
            }

            Match match = Regex.Match(flake, pattern);
            var length = match.Groups[1].Length;

            if (match.Success)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(length);
            }
            else Console.WriteLine("Invalid");
        }
    }
}
