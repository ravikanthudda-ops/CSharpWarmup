//Add two numbers
class SumOfTwo
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int secondNum = Convert.ToInt32(Console.ReadLine());
        int result = firstNum+secondNum;
        Console.WriteLine($"Addition of {firstNum} and {secondNum} is {result}");
    }
}