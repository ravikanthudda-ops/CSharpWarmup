using System;
class ArmStrongNumber
{
    static void Main()
    {
        Console.WriteLine("Enter any Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int tempNum = num;
        int numLen = 0;
        int digit = 0;
        while (num > 0)
        {
            numLen++;
            num = num/10; 
        }
        num = tempNum;
        while (num > 0)
        {
            digit += Convert.ToInt32(Math.Pow(num%10,numLen));
            num = num/10;
        }
        if (digit == tempNum)
        {
            Console.WriteLine($"{tempNum} is armstrong number");
        }
        else
        {
            Console.WriteLine($"{tempNum} is not an armstrong number");
        }
        Console.WriteLine($"Count of num is {numLen} and digit is {digit}");
    }
}