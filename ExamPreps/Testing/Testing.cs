using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Testing
    {
        static void Main(string[] args)
        {
            List<int> testList = new List<int>{ 4, 0, 3, 1, 2, 2, 0, 1 };
            testList.Sort();
            testList.Reverse();
            testList = testList.Distinct().ToList();
            Console.WriteLine();

        }
    }
}
