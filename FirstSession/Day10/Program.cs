using System;
class SumOfNumberDigit
{
    static void Main()
    {
        Console.WriteLine("Enter any Number");
        int num = Convert.ToInt32(Console.ReadLine());
        string arrNum = num.ToString();
        int tempNumber = 0;

        for(int i=0;i<arrNum.Length;i++)
        {
            tempNumber=Convert.ToInt32(arrNum[i].ToString())+tempNumber;
        }
        Console.WriteLine($"Sum is {tempNumber}");
    }
}