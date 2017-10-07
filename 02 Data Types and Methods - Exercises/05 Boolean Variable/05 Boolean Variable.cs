using System;

class Boolean_Variable
{
    static void Main(string[] args)
    {
        bool boolVariable = Convert.ToBoolean(Console.ReadLine());  // true, false
        Console.WriteLine(boolVariable?"Yes":"No");
    }
}