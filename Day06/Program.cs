using System;
using static System.Console;
public class Calculator
{
    public static int Addition(int x, int y)
    {
        return x + y;
    }
    public static int Subtraction(int x, int y)
    {
        return x - y;
    }
    public static int Multiplication(int x, int y)
    {
        return x * y;
    }
    public static int Division(int x, int y)
    {
        return x / y;
    }
    static void Main()
    {
        WriteLine("Enter first number");
        string num1 = ReadLine() ?? string.Empty;
        WriteLine("Enter second number");
        string num2 = ReadLine() ?? string.Empty;
        if (!int.TryParse(num1, out int number1) || !int.TryParse(num2, out int number2))
        {
            WriteLine("Enter valid number");
            return;
        }
        WriteLine("Choose option\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
        string option = ReadLine() ?? string.Empty;
        switch (option)
        {

            case "1":
                WriteLine($"Addition of {number1} and {number2} is {Addition(number1, number2)}");
                break;
            case "2":
                WriteLine($"Subtraction of {number1} and {number2} is {Subtraction(number1, number2)}");
                break;
            case "3":
                WriteLine($"Multiplication of {number1} and {number2} is {Multiplication(number1, number2)}");
                break;
            case "4":
                try
                {
                    WriteLine($"Division of {number1} and {number2} is {Division(number1, number2)}");
                }
                catch (DivideByZeroException ex)
                {
                    WriteLine($"Exception: {ex.Message}");
                }
                break;
            default:
                WriteLine("Invalid option");
                return;
        }
    }
}