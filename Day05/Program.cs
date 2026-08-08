using System;
public class LargestNum
{
    public static string CompareNum(int num1, int num2)
    {
        if (num1 < num2)
        {
            return $"{num2} is larger than {num1}";
        }
        else if (num1 > num2)
        {
            return $"{num1} is larger than {num2}";
        }
        else
        {
            return "Both numbers are equal";
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter first number");
        string number1 = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Enter second number");
        string number2 = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(number1, out int num1) && int.TryParse(number2, out int num2))
        {
            Console.WriteLine(CompareNum(num1, num2));
        }
        else
        {
            Console.WriteLine("Numbers are not valid");
        }
    }
}