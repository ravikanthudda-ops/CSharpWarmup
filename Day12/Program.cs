using System;
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());
        int reverseNum = 0;
        while (num > 0)
        {
            
            reverseNum = reverseNum*10;
            reverseNum += num%10;
            num = num/10;
        }
        Console.WriteLine($"Reverse Num is : {reverseNum}");
    }
}