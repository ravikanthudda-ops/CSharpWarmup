using System;
class Calculator
{
    double Add(double num1, double num2)
    {
        return num1+num2;
    }
    double Subtract(double num1, double num2)
    {
        return num1-num2;
    }
    double Multiply(double num1, double num2)
    {
        return num1*num2;
    }
    double Divide(double num1, double num2)
    {   
        return num1/num2;
    }
    static void Main()
    {
      Calculator calc = new Calculator();
      Console.WriteLine("Choose option\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
      string opt = Console.ReadLine()??string.Empty;
      Console.WriteLine("Enter two numbers");
      string num1 = Console.ReadLine()??string.Empty;
      string num2 = Console.ReadLine()??string.Empty;
      double result = 0;   
      if(double.TryParse(num1,out double number1) && double.TryParse(num2, out double number2))
      {
      switch(opt)
        {
            case "1":
                result = calc.Add(number1, number2);
                Console.WriteLine($"Addition of {num1} and {num2} is {result}");
            break;
            case "2":
                result = calc.Subtract(number1, number2);
                Console.WriteLine($"Subtraction of {num1} and {num2} is {result}");
            break;
            case "3":
                result = calc.Multiply(number1, number2);
                Console.WriteLine($"Multiplication of {num1} and {num2} is {result}");
            break;
            case "4":
                if(number2!=0){
                    result = calc.Divide(number1, number2);
                    Console.WriteLine($"Division of {num1} and {num2} is {result}");
                }
                else
                {
                    Console.WriteLine("Number can't be zero");
                }
            break;
            default:
            Console.WriteLine("Invalid input");
            break;
        }
      }
      else
      {
        Console.WriteLine("Invalid numbers");
      }
    }
}