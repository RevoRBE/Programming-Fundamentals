using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] a = new bool[n];
            for (int i = 2; i < n; i++) a[i] = true;
            int smallestP = 1;
            for (int i = 2; i < n; i++)
            {
                smallestP = Array.IndexOf(a, true, smallestP + 1);       //for (int j = 2; j < n; j++)          
                if (smallestP > 0) Console.Write($"{smallestP} ");     //{);          
                else return;                                           //    if (a[j])//is true          
                for (int j = 2; j < n; j++)                            //    {          
                {                                                      //        for (int p = 2; (p * j) < n; p++)          
                    if (j * smallestP >= a.Length) break;              //        {          
                    a[j * smallestP] = false;                          //            a[p * j] = false;          
                }                                                      //        }          
            }                                                          //    }          
        }                                                              //}          
    }
}       //List<int> indices = new List<int>();
        //for (int i = 0; i < a.Length; ++i)
        //{
        //    if (a[i])
        //    {
        //        indices.Add(i);
        //    }
        //}

//Console.WriteLine(String.Join(" ",indices));