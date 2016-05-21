using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Lab
    {
        static void Main(string[] args)
        {
            byte centuries = 0;
            for (int i = 0; i < 300; i++)
            {
                checked
                {
                    centuries++;
                    Console.WriteLine(centuries);
                }
            }
        }
    }
}
