using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList<string>();
            SortedDictionary<string, Dictionary<string, int>> usage = new SortedDictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string user = input[2].Substring(5);
                string IP = input[0].Substring(3);
                int counter = 1;
                if (!usage.ContainsKey(user))
                {
                    usage.Add(user, new Dictionary<string, int>());
                }
                if (!usage[user].ContainsKey(IP))
                {
                    usage[user].Add(IP, counter);
                }
                else
                {
                    usage[user][IP]++;
                }
                input = Console.ReadLine().Split(' ').ToList<string>();
            }
            foreach (var user in usage)
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last()) Console.Write($"{log.Key} => {log.Value}, ");
                    else Console.WriteLine($"{log.Key} => {log.Value}.");
                }
            }
        }
    }
}