using System;

class Vowel_or_Digit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (char.IsDigit(symbol)) Console.WriteLine("digit");
        else if ("aeiouAEIOU".Contains(symbol.ToString())) Console.WriteLine("vowel");
        else Console.WriteLine("other");
    }
}