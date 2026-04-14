using System;

public class Program
{
    public static void Main()
    {
        Console.Write("First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine("Sum = " + sum);
    }
}
