using System;

//separate class for operators
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Calculator calc = new Calculator();

        Console.WriteLine("Sum = " + calc.Add(num1, num2));
        Console.WriteLine("Difference = " + calc.Subtract(num1, num2));
        Console.WriteLine("Product = " + calc.Multiply(num1, num2));
    }
}