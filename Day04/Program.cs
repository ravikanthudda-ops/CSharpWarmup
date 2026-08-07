using System;
class EvenOdd
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        string num = Console.ReadLine()??string.Empty;

        if(int.TryParse(num,out int number))
        {
            if(number%2==0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine($"{num} is not valid");
        }
    }
}