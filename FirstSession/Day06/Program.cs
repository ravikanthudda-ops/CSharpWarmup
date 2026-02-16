using System;
class SimpleCalculator
{
    static int Add(int num1, int num2)
    {
        return num1+num2;
    }
    static int Subtract(int num1, int num2)
    {
        return num1-num2;
    }
    static void Main()
    {
        Console.WriteLine("Choose your calculation choice:\n1. Addition\n2. Subtraction");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine($"Addition of {num1} and {num2} is: {Add(num1,num2)}");
            break;
            case 2:
                Console.WriteLine($"Subtraction of {num1} and {num2} is: {Subtract(num1,num2)}");
            break;
            default:
                Console.WriteLine("Invalid Choice");
            break;
        }
    }
}