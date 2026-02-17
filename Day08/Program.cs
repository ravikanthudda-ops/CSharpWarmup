using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter any word!");
        string str = Console.ReadLine();//RAVI
        StringBuilder revStr=new StringBuilder();

       for(int i=str.Length-1;i>=0;i--)
        {
            revStr.Append(str[i]);
        }
        Console.WriteLine($"Reverse string of '{str}' is '{revStr}'");
    }
}