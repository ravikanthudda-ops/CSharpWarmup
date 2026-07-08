using System;
class PrintNameAge
{
    static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter your age");
        string age = Console.ReadLine()??string.Empty;
        Console.WriteLine($"Hi, {name}. Your age is {age}");
    }
}