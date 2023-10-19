using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference newReference = new Reference("Jhon", 3, 5, 6);
        string textReference = newReference.GetReference();
        Console.WriteLine(textReference);
    }
}