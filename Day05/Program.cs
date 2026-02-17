using System;
class LargestNum
{
    static void Main()
    {
        Console.WriteLine("Enter First Num");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Num");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine($"{num1} is greater than {num2}");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"{num2} is greater than {num1}");
        }
        else
        {
            Console.WriteLine($"Both are equal");
        }
    }
}