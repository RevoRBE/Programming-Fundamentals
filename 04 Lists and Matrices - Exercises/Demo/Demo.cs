using System;
using System.Collections.Generic;

namespace Demo
{
    public class Demo
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(0);           
            list.Add(0);

            list.Add(1);
            list.RemoveAll(x => x == 0);    // NB!

            Console.WriteLine(string.Join(" ", list));









        }
    }
}
