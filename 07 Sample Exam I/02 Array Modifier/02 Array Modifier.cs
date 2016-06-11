using System;
using System.Linq;

namespace Array_Modifier
{
    public class Array_Modifier
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                switch (command)
                {
                    case "swap":
                        {
                            int index1 = int.Parse(data[1]);
                            int index2 = int.Parse(data[2]);
                            if (index1 >= 0 && index1 < numbers.Length &&
                                index2 >= 0 && index2 < numbers.Length)
                            {
                                long temp = numbers[index1];
                                numbers[index1] = numbers[index2];
                                numbers[index2] = temp;
                            }
                            break;
                        }
                    case "multiply":
                        {
                            int index1 = int.Parse(data[1]);
                            int index2 = int.Parse(data[2]);
                            if (index1 >= 0 && index1 < numbers.Length &&
                                index2 >= 0 && index2 < numbers.Length)
                                numbers[index1] *= numbers[index2];
                            break;
                        }
                    case "decrease":
                        {
                            for (int i = 0; i < numbers.Length; i++)
                                numbers[i]--;
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}