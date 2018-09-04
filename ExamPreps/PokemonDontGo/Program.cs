using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            while (nums.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int element = 0;
                if (index < 0)
                {
                    element = nums[0];
                    nums[0] = nums[nums.Count - 1];
                }
                else if (index >= nums.Count)
                {
                    element = nums[nums.Count - 1];
                    nums[nums.Count - 1] = nums[0];
                }
                else
                {
                    element = nums[index];
                    nums.RemoveAt(index);
                }

                sum += element;

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= element)
                    {
                        // nums.Insert(i, current + element);
                        nums[i] += element;
                    }
                    else
                    {
                        // nums.Insert(i, current - element);
                        nums[i] -= element;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}