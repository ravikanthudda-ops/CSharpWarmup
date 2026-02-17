using System;
class SumOfDigits
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            sum +=num%10;
            num = num/10;
        }
        Console.WriteLine($"Sum is : {sum}");
    }
}