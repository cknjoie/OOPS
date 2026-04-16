using System;

public class Program
{
    public static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(1, 101);

        Console.WriteLine("Random number: " + number);
    }
}