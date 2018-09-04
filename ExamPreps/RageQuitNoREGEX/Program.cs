using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder word = new StringBuilder();
            StringBuilder count = new StringBuilder();
            StringBuilder result = new StringBuilder();
            var inDigits = false;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = Char.ToUpper(input[i]);
                if (inDigits)
                {
                    if (Char.IsDigit(ch))
                    {
                        count.Append(ch);
                    }
                    else
	                {
                        for (int j  = 0; j<int.Parse(count.ToString()); j++)
                        {
                            result.Append(word);
                            inDigits = false;
                            word.Clear();
                            word.Append(ch);
                        }
			        }
                }
            }
        }
     }  
}
