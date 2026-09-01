using static System.Console;
public class SumOfXNum
{
    public static double SumOfN(int num)
    {
        if(num==1)
            return 1;
        else if(num==0)
            return 0;
        else
        {
            double total = 0;
            
            if(num<0)
            {
                num=-num;
            }
            
            for(int x = 1;x<=num;x++)
            {
                total += (double)x;
            }
            return total;
        }
    }
    static void Main()
    {
        WriteLine("Enter any number");
        string num = Console.ReadLine()??string.Empty;
        if(int.TryParse(num, out int number)){
            if(number<0){
                WriteLine($"For N = {num}, result is {-SumOfN(number)} ");
            }
            else {
                WriteLine($"For N = {num}, result is {SumOfN(number)} ");
            }
        }
        else
            WriteLine("Enter valid number");   
    }
}