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

    import java.util.Scanner;

public class SubtractionExample {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        // Input first number
        System.out.print("Enter first number: ");
        double num1 = scanner.nextDouble();

        // Input second number
        System.out.print("Enter second number: ");
        double num2 = scanner.nextDouble();

        // Subtraction
        double result = num1 - num2;

        // Output result
        System.out.println("The result is: " + result);

        scanner.close();
    }
}
}
