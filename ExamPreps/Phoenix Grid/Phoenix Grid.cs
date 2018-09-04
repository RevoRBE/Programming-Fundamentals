using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            var validR = new Regex(@"^[^\s_]{3}(\.[^\s_]{3})*$");
            string input = Console.ReadLine();
            var output = new List<bool>();

            while (input != "ReadMe")
            {
                var valid = validR.Match(input);
                if (valid.Success) if (isPalindrome(valid.Groups[0].Value)) output.Add(true);
                    else output.Add(false);
                else output.Add(false);
                input = Console.ReadLine();
            }
            output.ForEach(x => { if (x == true) Console.WriteLine("YES"); else Console.WriteLine("NO"); });
        }

        private static bool isPalindrome(string myString)
        {
            string first = myString.Substring(0, myString.Length / 2);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
    }
}
