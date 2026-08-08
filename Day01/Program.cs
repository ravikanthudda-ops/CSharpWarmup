using System;
using static System.Console;
public class HelloWorld
{
    public static string GetMessage()
    {
        return "Hello, World!";
    }
    public static void Main()
    {
        WriteLine(GetMessage());
    }
}