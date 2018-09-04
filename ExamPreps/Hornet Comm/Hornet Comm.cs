using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var broadcastsR = new Regex(@"([^0-9]+) <-> ([A-Za-z0-9^]+)$");
            var messagesR = new Regex(@"^([0-9]+) <-> ([A-Za-z0-9]+)$");
            string input = Console.ReadLine();
            var broarr = new List<string>();
            var mesarr = new List<string>();

            while (input != "Hornet is Green")
            {
                var bromatch = broadcastsR.Match(input);
                var mesmatch = messagesR.Match(input);
                if (bromatch.Success)
                {
                    string temp = "";
                    for (int i = 0; i < bromatch.Groups[2].Value.Length; i++)
                    {
                        if (char.IsLower(bromatch.Groups[2].Value[i])) temp += bromatch.Groups[2].Value[i].ToString().ToUpper();
                        else temp += bromatch.Groups[2].Value[i].ToString().ToLower();
                    }
                    broarr.Add($"{temp} -> {bromatch.Groups[1]}");
                }
                if (mesmatch.Success) mesarr.Add($"{String.Join("", mesmatch.Groups[1].Value.ToCharArray().Reverse())} -> {mesmatch.Groups[2]}");
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broarr.Count < 1) Console.WriteLine("None");
            else broarr.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("Messages:");
            if (mesarr.Count < 1) Console.WriteLine("None");
            else mesarr.ForEach(e => Console.WriteLine(e));
        }
    }
}
