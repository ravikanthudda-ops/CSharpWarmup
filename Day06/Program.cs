class SimpleCalculator
{
    static decimal Add(decimal num1, decimal num2)
    {
        return num1+num2;
    }
    static decimal Subtract(decimal num1, decimal num2)
    {
        return num1-num2;
    }
    static decimal Multiply(decimal num1, decimal num2)
    {
        return num1*num2;
    }
    static decimal Divide(decimal num1, decimal num2)
    {
        if(num2!=0)
            return num1/num2;
        else
            throw new DivideByZeroException($"{num1} cannot be divided by {num2}");
    }
    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        if(decimal.TryParse(Console.ReadLine(), out decimal num1) && decimal.TryParse(Console.ReadLine(), out decimal num2))
        {
            Console.WriteLine("Perform Operation: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            if(int.TryParse(Console.ReadLine(),out int option))
            {
                switch(option)
                {
                    case 1:
                        Console.WriteLine($"Addition of {num1} and {num2} is {Add(num1, num2)}");
                    break;
                    case 2:
                        Console.WriteLine($"Subtraction of {num1} and {num2} is {Subtract(num1,num2)}");
                    break;
                    case 3:
                        Console.WriteLine($"Multiplication of {num1} and {num2} is {Multiply(num1,num2)}");
                    break;
                    case 4:
                    try{
                        Console.WriteLine($"Division of {num1} and {num2} is {Divide(num1,num2)}");
                    }
                    catch(DivideByZeroException ex)
                        {
                            Console.WriteLine($"Invalid Value: {ex.Message}");
                        }
                    break;
                    default:
                        Console.WriteLine("Invalid Operation");
                    break;
                }
            }
            else
                Console.WriteLine("Invalid operation");
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
}