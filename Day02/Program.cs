using System;
using static System.Console;
public class NameAndAge
{
    public static string CreateGreeting(string name, string age)
    {
        return $"Hi, {name}. You are {age} old";
    }
    static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter your age");
        string age = Console.ReadLine()??string.Empty;
        Console.WriteLine(CreateGreeting(name, age));
    }
}