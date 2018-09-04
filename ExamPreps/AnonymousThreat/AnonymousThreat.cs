using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class AnonymousThreat
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var initLlist = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            input = Console.ReadLine();
            while (input != "3:1")
            {
                var commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "merge") //Example: abcd efgh ijkl mnop qrst uvwx yz
                {
                    int sInd = int.Parse(commands[1]) >= 0 ? int.Parse(commands[1]) : 0;
                    int eInd = int.Parse(commands[2]) < initLlist.Count() ? int.Parse(commands[2]) : initLlist.Count()-1;
                    if (sInd >= initLlist.Count)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    int remove = eInd - sInd +1;
                    List<string> concat = initLlist.GetRange(sInd, remove);
                    initLlist.RemoveRange(sInd, remove);
                    initLlist.Insert(sInd, String.Concat(concat));
                }
                else //{abcdef, ghi, jkl} -> divide 0 3 -> {ab, cd, ef, ghi, jkl}
                { //{abcd, efgh, ijkl} -> divide 0 3 -> {a, b, cd, efgh, ijkl}
                    int ind = int.Parse(commands[1]);
                    int divizor = int.Parse(commands[2]);
                    var toDevide = initLlist[ind];
                    initLlist.RemoveAt(ind);
                    var devided = new string[divizor];
                    var part = toDevide.Length / divizor;
                    for (int i = 0; i < divizor; i++)
                    {
                        devided[i] = toDevide.Substring(0, part);
                        toDevide = toDevide.Substring(part);
                    }
                    devided[divizor - 1] += toDevide;
                    initLlist.InsertRange(ind, devided);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", initLlist.ToArray()));
        }
    }
}
