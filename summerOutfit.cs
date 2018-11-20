using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int gradus = int.Parse(Console.ReadLine());
            string diapazon = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (10 <= gradus && gradus <= 18)
            {
                if (diapazon == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (diapazon == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (diapazon == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (18 < gradus && gradus <= 24)
            {
                if (diapazon == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (diapazon == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (diapazon == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (gradus >= 25)
            {
                if (diapazon == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (diapazon == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (diapazon == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");

        }
    }
}





