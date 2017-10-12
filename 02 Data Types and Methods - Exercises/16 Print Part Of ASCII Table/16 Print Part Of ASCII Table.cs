using System;

class Print_Part_Of_ASCII_Table
{
    static void Main()
    {
        int indexStart = int.Parse(Console.ReadLine());
        int indexEnd = int.Parse(Console.ReadLine());

        for (int i = indexStart; i <= indexEnd; i++)
            Console.Write("{0} ", (char)i);
    }
}