using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Max_Method
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(n1, n2),n3));
        }

        static int GetMax(int n1, int n2)
        {
            
            return n1>n2?n1:n2;
        }
    }
}
