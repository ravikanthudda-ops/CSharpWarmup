using System;
class CountDigitInNumber
{
    static void Main()
    {
        Console.WriteLine("Enter any number");
        string num = Console.ReadLine()??string.Empty;
        int counter = 0;
        if(int.TryParse(num, out int number))
        {
            if(number<0)
            {
                number-=number*2;
            }
            if(number==0)
            {
                Console.WriteLine($"Digits in {number} is 1");
                return;
            }
            for(int i=number;i>0;i=i/10)
            {                
                counter++;
            }
            Console.WriteLine($"Digits in {number} are {counter}");
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
}