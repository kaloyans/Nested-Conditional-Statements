using System;

namespace nestedCondStateLab
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (sales > 0 && sales <= 500)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", sales * 5 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", sales * 4.5 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", sales * 5.5 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (sales > 500 && sales <= 1000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", sales * 7 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", sales * 7.5 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", sales * 8 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", sales * 8 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", sales * 10 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", sales * 12 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }
            else if (sales > 10000)
            {
                if (town == "Sofia")
                    Console.WriteLine("{0:f2}", sales * 12 / 100);
                else if (town == "Varna")
                    Console.WriteLine("{0:f2}", sales * 13 / 100);
                else if (town == "Plovdiv")
                    Console.WriteLine("{0:f2}", sales * 14.5 / 100);
                else if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv"))
                    Console.WriteLine("error");

            }

            else if (sales < 0)
            {
                Console.WriteLine("error");
            }


        }
    }
}
