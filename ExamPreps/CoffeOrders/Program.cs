using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int ord = int.Parse(Console.ReadLine());
        decimal totalPrice = 0;
        for (int i = 0; i < ord; i++)
        {
            decimal price = ProcessOrder();
            totalPrice += price;
        }
        Console.WriteLine($"Total: ${totalPrice:F2}");
    }

    private static decimal ProcessOrder()
    {
        decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
        string dateStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
        decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
        decimal capsulesCount = decimal.Parse(Console.ReadLine());
        decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;
        Console.WriteLine($"The price for the coffee is: ${price:F2}");
        return price;
    }
}
