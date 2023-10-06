using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        
        string choice = "0";
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What do you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            if (choice == "2")
            {
                journal.Display();
            } 
            if (choice == "3")
            {
                journal.LoadFile();
            }
            if (choice == "4")
            {
                journal.SaveFile();
            }
        }
        while (choice != "5");
    }
}