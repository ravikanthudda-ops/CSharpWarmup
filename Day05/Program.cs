class LargestOfTwo
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        if(int.TryParse(Console.ReadLine(), out int num1) && int.TryParse(Console.ReadLine(), out int num2)){
        if(num1>num2)
            Console.WriteLine($"Num {num1} is largest");
        else if(num2>num1)
            Console.WriteLine($"Num {num2} is largest");
        else
            Console.WriteLine("Both are same");
        }
        else
        Console.WriteLine("Invalid Number");
    }
}