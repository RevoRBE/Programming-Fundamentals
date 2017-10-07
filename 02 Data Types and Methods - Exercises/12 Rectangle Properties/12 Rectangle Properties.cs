using System;

class Rectangle_Properties
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;
        double diagonal = Math.Sqrt(width * width + height * height);
        Console.WriteLine(string.Join("\n", perimeter, area, diagonal));
    }
}