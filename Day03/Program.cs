using System;
class AddTwoNumberProgram
{
    static void Main()
    {
        Console.WriteLine("Enter First Number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int result = num1+num2;
        Console.WriteLine($"Result is :{result}");
    }
}