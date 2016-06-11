using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUni_Water_Suppliesram
{
    public static void Main()
    {
        decimal waterAmount = decimal.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse).ToArray();
        int bottleCapacity = int.Parse(Console.ReadLine());
        bool reversedArray = false;

        if (waterAmount % 2 != 0)
        {
            reversedArray = true;
            Array.Reverse(bottles);
        }
        int unfilledBottleIndex = -1;

        for (int i = 0; i < bottles.Length; i++)
        {
            decimal refill = bottleCapacity - bottles[i];
            if (waterAmount > refill)
            {
                bottles[i] += refill;
                waterAmount -= refill;
            }
            else
            {
                bottles[i] += waterAmount;
                waterAmount = 0;
                if (bottles[i] < bottleCapacity)
                {
                    unfilledBottleIndex = i; break;
                }
            }
        }
        if (unfilledBottleIndex == -1)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {waterAmount}l.");
        }
        else
        {
            List<int> unfilledBottleIndices = new List<int>();
            for (int i = unfilledBottleIndex; i < bottles.Length; i++)
            {
                if (!reversedArray) unfilledBottleIndices.Add(i);
                else                unfilledBottleIndices.Add(bottles.Length - 1 - i);
            }
            decimal waterShortage = 0;
            for (int i = unfilledBottleIndex; i < bottles.Length; i++)
                waterShortage += bottleCapacity - bottles[i];
            Console.WriteLine("We need more water!");
            Console.WriteLine("Bottles left: {0}", unfilledBottleIndices.Count);
            Console.WriteLine("With indexes: {0}", string.Join(", ", unfilledBottleIndices));
            Console.WriteLine("We need {0} more liters!", waterShortage);
        }
    }
}