using System;
using System.Globalization;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double priceForStudio = 0;
        double priceForApartment = 0;


        switch (month)
        {
            case "May":
                case "October":
                priceForStudio = 50;
                priceForApartment = 65;
                if (nightsCount > 14)
                {
                    priceForStudio *= 0.7;
                    priceForApartment *= 0.9;
                }
                else if (nightsCount > 7)
                {
                    priceForStudio *= 0.95;
                }
                break;
            case "June":
                case "September":
                priceForStudio = 75.20;
                priceForApartment = 68.70;
                if (nightsCount > 14)
                {
                    priceForStudio *= 0.8;
                    priceForApartment *= 0.9;
                }
                break;
            case "July":
            case "August":
                priceForStudio = 76;
                priceForApartment = 77;
                if (nightsCount > 14)
                {
                    priceForApartment *= 0.9;
                }
                break;
        }
        double totalStudioPrice = priceForStudio * nightsCount;
        double totalApartmentPrice = priceForApartment * nightsCount;

        Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
    }
}
