using System;
class LargestNum
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        string number1 = Console.ReadLine()??string.Empty;
        Console.WriteLine("Enter second number");
        string number2 = Console.ReadLine()??string.Empty;

        if(int.TryParse(number1, out int num1) && int.TryParse(number2, out int num2))
        {
            if(num1<num2)
            {
                Console.WriteLine($"{num2} is larger than {num1}");
            }
            if(num1>num2)
            {
                Console.WriteLine($"{num1} is larger than {num2}");
            }
            if(num1==num2)
            {
                Console.WriteLine("Both numbers are equal");
            }
        }
        else
        {
            Console.WriteLine("Numbers are not valid");
        }
    }
}