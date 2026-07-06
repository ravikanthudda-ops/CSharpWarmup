using System;
class PrintNameAge
{
    static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hi, {name}. Your age is {age}");
    }
}