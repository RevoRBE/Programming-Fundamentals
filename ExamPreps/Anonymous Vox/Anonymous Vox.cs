using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"([a-zA-Z]+)\S+\1";
        string placeholders = Console.ReadLine();
        string[] words = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        MatchCollection matches = Regex.Matches(placeholders, pattern);
        int counter = 0;
        foreach (Match m in matches)
        {
            string inserted = m.Groups[1] + words[counter++] + m.Groups[1];
            placeholders = placeholders.Replace(m.Value, inserted);
        }
        Console.WriteLine(placeholders);
     }
}
