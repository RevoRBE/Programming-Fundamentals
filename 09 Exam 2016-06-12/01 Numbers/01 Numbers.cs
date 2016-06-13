using System;
using System.Linq;

class Numbers
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();
        int[] top5Numbers = numbers.Where(x => x > numbers.Average())
                        .OrderByDescending(x => x)
                        .Take(5).ToArray();
        if (top5Numbers.Length > 0)
            Console.WriteLine(string.Join(" ", top5Numbers));
        else Console.WriteLine("No");
    }
}