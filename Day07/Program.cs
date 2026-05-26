//Leapyear is what is divisible by 4 and 400
class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter a year to know whether year is leap year or not");
        if(int.TryParse(Console.ReadLine(),out int year))
        {
            if(year%400==0)
            {
                Console.WriteLine("Leap Year");
            }
            else if(year%100==0)
            {
                Console.WriteLine("Not a leap year");
            }
            else if(year %4==0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
        else
        {
            Console.WriteLine("Invalid value");
        }
    }
}