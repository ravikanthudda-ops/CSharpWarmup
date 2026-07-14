using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter any string to reverse");
        string str = Console.ReadLine()??string.Empty;
        StringBuilder sb = new StringBuilder();
        for(int j=str.Length-1;j>=0;j--)
        {
            sb.Append(str[j]);
        }
        Console.WriteLine($"Reverse string is {sb}");
    }
}