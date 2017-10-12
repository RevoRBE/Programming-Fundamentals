using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long ft = long.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine()) / 100;
        long t = long.Parse(Console.ReadLine());

        long ttf = n * ft;
        long worthy = (long)Math.Ceiling(n * p);
        long ttu = worthy * t;
        long totalS = ttu + ttf;
        //TimeSpan duration = new TimeSpan(0, 0, totalM, totalS);
        //Console.WriteLine(duration.ToString(@"d\:hh\:mm\:ss"));
        TimeSpan time = TimeSpan.FromSeconds(totalS);
        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
    }
}