using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Everyone!");
        Console.WriteLine("This is in C#.");
        Console.Write("What is your lucky number? ");
        string number = Console.ReadLine();
        Console.WriteLine($"Your number is {number}");
    }
}