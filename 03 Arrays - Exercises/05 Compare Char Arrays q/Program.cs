using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays_q
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i]) continue;
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("{0}\n{1}", String.Join("", arr1), String.Join("", arr2));
                    break;
                }
                else
                {
                    Console.WriteLine("{0}\n{1}", String.Join("", arr2), String.Join("", arr1));
                    break;
                }
            }
            if (arr1.Length < arr2.Length) Console.WriteLine("{0}\n{1}", String.Join("", arr1), String.Join("", arr2));
            else Console.WriteLine("{0}\n{1}", String.Join("", arr2), String.Join("", arr1));
        }
    }
}
