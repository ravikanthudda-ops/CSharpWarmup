using System;
class EvenOddProgram
{
    static void Main()
    {
        Console.WriteLine("Enter Any Number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}