using static System.Console;

public class SumAndAvg
{
    public static double[] SumAndAvgResult(int[] num)
    {
        double[] total = new double[2];
        for(int i=0; i<num.Length; i++)
            total[0] += num[i];
        total[1] = total[0]/num.Length;
        return total;
    }
    static void Main()
    {
        WriteLine("Enter any 5 numbers");
        const int count = 5;
        int[] arr = new int[count];
        for(int i=0; i<5; i++)
        {
            string num = Console.ReadLine()??string.Empty;
            if(int.TryParse(num, out int number))
            {
                arr[i] = number;
            }
            else
            {
                Console.WriteLine("Enter valid number");
                return;
            }
        }
        double[] total = SumAndAvgResult(arr);
        WriteLine($"Sum of 5 numbers is {total[0]} and avg is {total[1]}");
    }
}