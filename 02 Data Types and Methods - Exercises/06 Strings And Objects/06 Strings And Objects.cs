using System;

class String_and_Objects
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        object abo = a + ' ' + b;
        string abs = (string)abo;
        Console.WriteLine(abs);
        //Console.WriteLine(string.Join(" ", a, b));
    }
}