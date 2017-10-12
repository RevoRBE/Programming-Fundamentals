using System;

class Comparing_floats
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double precision = 0.000001d;

        double diff = Math.Abs(number1 - number2);
        Console.WriteLine(diff < precision);    // diff < required precision => equal numbers
    }
}