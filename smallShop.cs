using System;

namespace nestedCondStateLab
{
    class Program
    {
        static void Main(string[] args)
        {

            string productname = Console.ReadLine();
            string townName = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (townName == "Sofia")
            {
                if (productname == "coffee")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                else if (productname == "water")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (productname == "beer")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (productname == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (productname == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (townName == "Plovdiv")
            {
                if (productname == "coffee")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else if (productname == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (productname == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (productname == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (productname == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50);
                }
            }
            else if (townName == "Varna")
            {
                if (productname == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (productname == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (productname == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (productname == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (productname == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            }
        }
    }
}
