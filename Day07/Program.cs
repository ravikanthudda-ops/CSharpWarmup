using System;
using static System.Console;
public class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        /*
        // Unoptimized version
        if((year%4==0 && year%100!=0) || year%400==0)
            return true;
        else
            return false;
            */
        // simplest version
        return ((year%4==0 && year%100!=0) || year%400==0);
    } 
    static void Main()
    {
        WriteLine("Enter any year");
        string num = ReadLine()??string.Empty;
        if(int.TryParse(num,out int year))
        {
            if(IsLeapYear(year))
                WriteLine("Leap year");
            else
                WriteLine("Not a leap year");
        }
        else
        {
            WriteLine("Invalid value");
        }
    }
}