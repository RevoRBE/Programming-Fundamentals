using System;
using System.Collections.Generic;
using System.Globalization;

namespace Count_Working_Days
{
    class Holiday
    {
        public int Day { get; set; }
        public int Month { get; set; }        
    }

    public class Count_Working_Days
    {
        public static void Main()
        {
            List<Holiday> holidays = GetHolidays();
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int countWorkingDays = 0;
            for (DateTime date = firstDate; date <= secondDate; date = date.AddDays(1))
            {
                bool isNonWorkingDay =  IsHoliday(date, holidays) ||
                                        date.ToString("dddd") == "Saturday" || 
                                        date.ToString("dddd") == "Sunday";
                if (!isNonWorkingDay)
                    countWorkingDays++;
            }
            Console.WriteLine(countWorkingDays);
        }

        private static bool IsHoliday(DateTime date, List<Holiday> holidays)
        {
            foreach (var holiday in holidays)
                if (date.Month == holiday.Month && date.Day == holiday.Day)
                    return true;
            return false;
        }

        private static List<Holiday> GetHolidays()
        {
            List<Holiday> holidays = new List<Holiday>();
            holidays.Add(new Holiday { Day = 1, Month = 1 });
            holidays.Add(new Holiday { Day = 3, Month = 3 });
            holidays.Add(new Holiday { Day = 1, Month = 5 });
            holidays.Add(new Holiday { Day = 6, Month = 5 });
            holidays.Add(new Holiday { Day = 24, Month = 5 });
            holidays.Add(new Holiday { Day = 6, Month = 9 });
            holidays.Add(new Holiday { Day = 22, Month = 9 });
            holidays.Add(new Holiday { Day = 1, Month = 11 });
            holidays.Add(new Holiday { Day = 24, Month = 12 });
            holidays.Add(new Holiday { Day = 25, Month = 12 });
            holidays.Add(new Holiday { Day = 26, Month = 12 });
            return holidays;
        }
    }
}