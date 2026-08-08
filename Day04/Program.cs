using System;
public class EvenOdd
{
    public static string EvenOrOdd(int num)
    {
        if(num%2==0)
            return "Even";
        else
            return "Odd";
    }
    static void Main()
    {
        Console.WriteLine("Enter any number");
        string num = Console.ReadLine()??string.Empty;

        if(int.TryParse(num,out int number))
        {            
                Console.WriteLine(EvenOrOdd(number));
        }
        else
        {
            Console.WriteLine($"{num} is not valid");
        }
    }
}