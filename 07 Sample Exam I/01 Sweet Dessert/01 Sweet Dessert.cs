using System;

namespace Sweet_Dessert
{
    public class Sweet_Dessert
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal[] prices = new decimal[3]; // bananas, eggs, berries (kg)
            for (int i = 0; i < 3; i++)
                prices[i] = decimal.Parse(Console.ReadLine());
            int sets = (int)Math.Ceiling(guests / 6.0);
            decimal expenses = (2 * prices[0] + 4 * prices[1] + 0.2m * prices[2]) * sets;
            if (expenses <= cash)
                Console.WriteLine($"Ivancho has enough money - it would cost {expenses:f2}lv.");
            else
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", expenses - cash);
        }
    }
}