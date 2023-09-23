using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        string response = "yes";

        while (response == "yes")
        {
            // Console.Write("What is the magic number? ");
            // string magic = Console.ReadLine();
            // int magicNumber = int.Parse(magic);
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber = 0;
            int track = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                // Comparing the magic and the guess number

                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                track ++;
            }while (guessNumber != magicNumber);
            Console.WriteLine($"You made {track} guesses.");
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}