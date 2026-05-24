//Print Name and Age
class NameAge
{
    static void Main()
    {
        Console.WriteLine("Enter Your Name");
        string Name = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hi {Name}, you are {Age} old");
    }
}