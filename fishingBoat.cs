using System;
using System.Globalization;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fisherManCount = int.Parse(Console.ReadLine());

        double discount = 0;
        double boatRent = 0;

        double currentSum = 0;

        if (fisherManCount >= 12)
        {
            discount = 0.25;
            if (season == "Spring")
            {
                boatRent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;
            }
            else
            {
                boatRent = 2600;
            }
        }
        else if (fisherManCount >= 7)
        {
            discount = 0.15;
            if (season == "Spring")
            {
                boatRent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;
            }
            else
            {
                boatRent = 2600;
            }
        }
        else
        {
            discount = 0.1;
            if (season == "Spring")
            {
                boatRent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;
            }
            else
            {
                boatRent = 2600;
            }
        }

        currentSum = boatRent - (boatRent * discount);

        if (fisherManCount % 2 == 0 && season != "Autumn")
        {
            currentSum = currentSum - (currentSum * 0.05);
        }

        double diff = 0;

        if (currentSum > budget)
        {
            diff = currentSum - budget;
            Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
        }
        else
        {
            diff = budget - currentSum;
            Console.WriteLine($"Yes! You have {diff:F2} leva left.");
        }
    }
}

