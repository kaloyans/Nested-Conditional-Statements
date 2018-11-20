using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string projection = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double price = 0.0;

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            

            if (projection == "Premiere")
            {
                price = 12.00;
            }
            else if (projection == "Normal")
            {
                price = 7.50;
            }
            else if (projection == "Discount")
            {
                price = 5.00;
            }

            Console.WriteLine("{0:F2} leva",price * r *c);

        }
    }
}
