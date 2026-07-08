using System;
class Addition
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        string num1 = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter second number");
        string num2 = Console.ReadLine()??string.Empty;
        if(int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
        {
            Console.WriteLine($"Addition of {num1} and {num2} is {number1+number2}");
        }
        else
        {
            Console.WriteLine("Enter valid numbers");
        }
    }
}