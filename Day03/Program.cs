using System;
public class AddNumber
{
    public static int Addition(int num1, int num2)
    {
        return num1+num2;
    }
    static void Main()
    {
        Console.WriteLine("Enter first number");
        string num1 = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter second number");
        string num2 = Console.ReadLine()??string.Empty;

        if(int.TryParse(num1,out int number1) && int.TryParse(num2, out int number2))
        {
            Console.WriteLine($"Sum of {number1} and {number2} is {Addition(number1, number2)}");
        }
        else
        {
            Console.WriteLine("Entered number is not correct");
        }
    }
}