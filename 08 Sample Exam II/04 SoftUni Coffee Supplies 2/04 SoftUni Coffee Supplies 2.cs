using System;
using System.Collections.Generic;
using System.Linq;

class SoftUni_Coffee_Supplies
{
    static void Main()
    {
        string[] separators = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, string> coffeeTypePreferences = new Dictionary<string, string>();
        Dictionary<string, long> coffeeTypeQuantities = new Dictionary<string, long>();

        // get coffee type preferences & quantities
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of info") break;

            string coffeeType = "";
            int quantity = 0;
            if (input.Contains(separators[0]))
            {
                string[] data = input.Split(new string[] { separators[0] }, StringSplitOptions.RemoveEmptyEntries);
                string person = data[0];
                coffeeType = data[1];
                coffeeTypePreferences[person] = coffeeType;
            }
            else if (input.Contains(separators[1]))
            {
                string[] data = input.Split(new string[] { separators[1] }, StringSplitOptions.RemoveEmptyEntries);
                coffeeType = data[0];
                quantity = int.Parse(data[1]);
            }
            if (!coffeeTypeQuantities.ContainsKey(coffeeType))
                coffeeTypeQuantities[coffeeType] = 0;
            coffeeTypeQuantities[coffeeType] += quantity;
        }
        PrintOutOfCoffeeStats(coffeeTypeQuantities);
        coffeeTypeQuantities = GetCoffeeConsumption(coffeeTypePreferences, coffeeTypeQuantities);
        PrintStats(coffeeTypePreferences, coffeeTypeQuantities);
    }

    private static void PrintStats(Dictionary<string, string> coffeeTypePreferences, Dictionary<string, long> coffeeTypeQuantities)
    {
        Console.WriteLine("Coffee Left:");
        foreach (var remainingCoffee in coffeeTypeQuantities.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            Console.WriteLine(string.Join(" ", remainingCoffee.Key, remainingCoffee.Value));    // type, quantity desc.

        Console.WriteLine("For:");
        foreach (string remainingCoffeeType in coffeeTypeQuantities.Where(x => x.Value > 0)
                                                            .OrderBy(x => x.Key)                // coffee type asc.
                                                            .Select(x => x.Key).ToList())
            foreach (string person in coffeeTypePreferences.Where(x => x.Value == remainingCoffeeType)
                                                            .OrderByDescending(x => x.Key)      // person desc.
                                                            .Select(x => x.Key).ToList())
                Console.WriteLine("{0} {1}", person, remainingCoffeeType);
    }

    private static Dictionary<string, long> GetCoffeeConsumption(Dictionary<string, string> coffeeTypePreferences, Dictionary<string, long> coffeeTypeQuantities)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of week") break;

            string[] data = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string person = data[0];
            int coffeeQuantity = int.Parse(data[1]);
            string coffeeType = coffeeTypePreferences[person];

            coffeeTypeQuantities[coffeeType] -= coffeeQuantity;
            if (coffeeTypeQuantities[coffeeType] <= 0)
                Console.WriteLine("Out of {0}", coffeeType);
        }
        return coffeeTypeQuantities;
    }

    private static void PrintOutOfCoffeeStats(Dictionary<string, long> coffeeTypeQuantities)
    {
        foreach (var remainingCoffee in coffeeTypeQuantities.Where(x => x.Value == 0))
            Console.WriteLine("Out of {0}", remainingCoffee.Key);   // coffee type
    }
}