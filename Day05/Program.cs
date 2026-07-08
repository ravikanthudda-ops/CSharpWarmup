using System;
class LargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter any two numbers");
        string num1 = Console.ReadLine()??string.Empty;
        string num2 = Console.ReadLine()??string.Empty;
        if(int.TryParse(num1, out int number1) && int.TryParse(num2, out int number2))
        {
            if(number1>number2)
                Console.WriteLine($"{number1} is greater");
            else if(number1<number2)
                Console.WriteLine($"{number2} is greater");
            else
                Console.WriteLine($"Both numbers are same");
        }
        else
        {
            Console.WriteLine("Invalid numbers");
        }
    }
}