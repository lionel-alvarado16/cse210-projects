using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
           
        string choice = "0";

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunActivity();
            }

            if (choice == "2")
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunActivity();
            }

            if (choice == "3")
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.RunActivity();
            }

        } while (choice != "4");
    }
}