using static System.Console;

namespace CSharpWarmup;
public class CountDigitInNumber
{
    public static int DigitCount(int number)
    {
        if (number < 0)
            number = - number;
        if(number==0) 
            return 1;
            
        int count = 0;
        while(number>0)
        {            
            number /= 10;
            count += 1;
        }
        return count;
    }
    static void Main()
    {
        WriteLine("Enter any number");
        string num = Console.ReadLine()??string.Empty;

        if(int.TryParse(num, out int number))
        {
            WriteLine(DigitCount(number));
        }        
    }
}