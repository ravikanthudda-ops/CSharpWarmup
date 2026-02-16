using System;
class CheckLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter a year");
        int year = Convert.ToInt32(Console.ReadLine());
        if(year%400==0 ||(year%4==0 && year%100!=0))
        {
            Console.WriteLine($"{year} is leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}