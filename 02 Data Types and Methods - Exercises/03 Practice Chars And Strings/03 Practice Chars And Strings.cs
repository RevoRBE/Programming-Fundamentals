using System;

class Chars_and_Strings
{
    static void Main()
    {
        string text1 = Console.ReadLine();
        char text2 = Console.ReadKey().KeyChar;
        Console.ReadKey();
        char text3 = Console.ReadKey().KeyChar;
        Console.ReadKey();
        char text4 = Console.ReadKey().KeyChar;
        Console.ReadKey();
        string text5 = Console.ReadLine();
        Console.WriteLine($"{text1}\n{text2}\n{text3}\n{text4}\n{text5}");
    }
}