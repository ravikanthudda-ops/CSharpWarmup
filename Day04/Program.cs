class EvenOdd
{
    static void Main()
    {
        Console.WriteLine("Enter any number to check even/odd");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number%2==0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}