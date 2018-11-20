using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string yearType = Console.ReadLine();
            int pHolidays = int.Parse(Console.ReadLine());
            int hWeekendsInHome = int.Parse(Console.ReadLine());

            int allWeekendsYear = 48;
            int normalWeekends = allWeekendsYear - hWeekendsInHome;
            double totalPlays = normalWeekends * 3.0 / 4;
            totalPlays += hWeekendsInHome;
            totalPlays += pHolidays * 2.0 / 3;

            switch (yearType)
            {
                case "leap":
                    totalPlays += totalPlays * 0.15;
                    break;
                case "normal":
                    totalPlays = totalPlays;
                    break;
            }
            Console.WriteLine(Math.Floor(totalPlays));

        }
    }
}
