using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Work_Days_Q
{
    class Program
    {
        static void Main()
        {
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] holidays = new DateTime[]
            {
            new DateTime(end.Year, 01, 01),
            new DateTime(end.Year, 03, 03),
            new DateTime(end.Year, 05, 01),
            new DateTime(end.Year, 05, 06),
            new DateTime(end.Year, 05, 24),
            new DateTime(end.Year, 09, 06),
            new DateTime(end.Year, 09, 22),
            new DateTime(end.Year, 11, 01),
            new DateTime(end.Year, 12, 24),
            new DateTime(end.Year, 12, 25),
            new DateTime(end.Year, 12, 26)
            };
            int counter = 0;
            for (DateTime date = start; date <= end; date = date.AddDays(1))
            {
                bool isNonWorkingDay = holidays.Contains(date) ||
                                    date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
                if (!isNonWorkingDay) counter++;
            }
            Console.WriteLine(counter);
        }

    }
}
