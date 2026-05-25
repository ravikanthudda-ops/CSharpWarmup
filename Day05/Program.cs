class LargestOfTwo
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        if(num1>num2)
            Console.WriteLine($"Num {num1} is largest");
        else if(num2>num1)
            Console.WriteLine($"Num {num2} is largest");
        else
            Console.WriteLine("Both are same");
    }
}