using System;
class AddNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        string num1 = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter second number");
        string num2 = Console.ReadLine()??string.Empty;

        if(int.TryParse(num1,out int number1) && int.TryParse(num2, out int number2))
        {
            int result = number1+number2;
            Console.WriteLine($"Sum of {number1} and {number2} is {result}");
        }
        else
        {
            Console.WriteLine("Entered number is not correct");
        }
    }
}