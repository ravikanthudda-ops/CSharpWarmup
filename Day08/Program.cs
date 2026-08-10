using System;
using static System.Console;
public class ReverseString
{
    public static string ReversedString(string str)
    {
        string revStr = string.Empty;
        for(int i=str.Length-1;i>=0;i--)
        {
            revStr +=str[i];
        }
        return revStr;
    }
    static void Main()
    {
        WriteLine("Enter any string");
        string str = Console.ReadLine()??string.Empty;
        WriteLine($"Reverse of {str} is {ReversedString(str)}");
    }
}