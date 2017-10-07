using System;

class Reversed_chars
{
    static void Main()
    {
        char[] letters = new char[3];
        for (int i = 0; i < letters.Length; i++)
            letters[i] = (Console.ReadLine()[0]);
        Array.Reverse(letters);
        Console.WriteLine(string.Join("", letters));
    }
}