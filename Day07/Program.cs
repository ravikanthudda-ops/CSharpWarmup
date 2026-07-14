using System;
class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter any year");
        string year = Console.ReadLine()??string.Empty;
        if(int.TryParse(year,out int yy))
        {
            if(yy%4==0 && (yy%100!=0 || yy%400==0))
            {
                    Console.WriteLine("Leap Year");             
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }
        }
        else
        {
            Console.WriteLine("Invalid Year");
        }
    }
}