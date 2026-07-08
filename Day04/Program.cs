using System;
class EvenOdd
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        string num = Console.ReadLine()??string.Empty;
        if(int.TryParse(num, out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
    }
}