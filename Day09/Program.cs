using System;
class CountDigit
{
    static void Main()
    {
        Console.WriteLine("Enter any number to get count of digit");
        string num = Console.ReadLine();
        int numCount = 0;
        for(int i = 0; i < num.Length; i++)
        {
            if(num[i]>='0' && num[i]<='9')
            {
                numCount++;
            }
        }
        Console.WriteLine($"Count of digit in {num} are {numCount}");
    }
}