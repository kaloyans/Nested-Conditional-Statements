using System;
using System.Globalization;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        string evenOrOdd = "";
        string @operator = Console.ReadLine();

        double result = default(double);

        try
        {
            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - {evenOrOdd}");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - {evenOrOdd}");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    evenOrOdd = result % 2 == 0 ? "even" : "odd";
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - {evenOrOdd}");
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    if (secondNumber == 0)
                    {
                        throw new ArgumentException($"Cannot divide {firstNumber} by zero");
                    }
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    if (secondNumber == 0)
                    {
                        throw new ArgumentException($"Cannot divide {firstNumber} by zero");
                    }
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                    break;
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

