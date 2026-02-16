using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Your Name");
        string Name = Console.ReadLine();
        Console.WriteLine("Enter Your Age");
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hi {Name}, you are {Age} old");
    }
}