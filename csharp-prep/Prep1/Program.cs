using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");

        // Ask the user for their name.
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
        // Console.WriteLine();
    }
}