using System;

class Convert_Speed_Units
{
    static void Main()
    {
        float distanceMeters = float.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float speedMSec = (float)distanceMeters / (seconds + minutes * 60f + hours * 60f * 60);
        float speedKmH = (float)distanceMeters / 1000f / (hours + minutes / 60f + seconds / 60f / 60);
        float speedMPH = (float)distanceMeters / 1609f / (hours + minutes / 60f + seconds / 60f / 60);
        Console.WriteLine(speedMSec);
        Console.WriteLine(speedKmH);
        Console.WriteLine(speedMPH);
    }
}