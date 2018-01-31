using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "IP=FE80:0000:0000:0000:0202:B3FF:FE1E:8329 message='Hey&son' user=mother".Split(' ').ToArray();
            SortedDictionary<string, Dictionary<string, int>> usage = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                var tempuser = input[2].Substring(6);
                var tempip = input[0].Substring(4);
                
                //usage[] = new Dictionary<string, int>
                //string name = input;
                //input = Console.ReadLine();
                //string mail = input;
                //string domain = input.Substring(input.Length-2);
                //if (domain != "us" && domain != "uk")
                //{
                //    mails[name]= mail;
                //}
                //input = Console.ReadLine();
            }
            //foreach (var mail in mails) Console.WriteLine($"{mail.Key} -> {mail.Value}");
        }
    }
}
