using System;
class Palindrome
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());
        //12321
        int reverseNum = 0;
        int temp  = num;
        while (num > 0)
        {
            reverseNum *= 10;
            reverseNum += num%10;       
            num /= 10;
        }
        if(temp == reverseNum)
        {
            Console.WriteLine($"Number {temp} and {reverseNum} is palindrome");
        }
        else
        {
            Console.WriteLine($"Number {temp} and {reverseNum} is not palindrome");
        }
    }
}