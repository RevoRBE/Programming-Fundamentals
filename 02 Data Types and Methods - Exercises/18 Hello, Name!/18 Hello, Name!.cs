using System;

class Hello_Name
{
    static void Main(string[] args)
    {
        Greet(Console.ReadLine());
    }

    static void Greet(string name)
    {
        Console.WriteLine("Hello, {0}!", name);

    }
}