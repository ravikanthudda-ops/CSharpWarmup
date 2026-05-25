//Print Name and Age
class NameAge
{
    static void Main()
    {
        Console.WriteLine("Enter Your Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hi {name}, you are {age} old");
    }
}