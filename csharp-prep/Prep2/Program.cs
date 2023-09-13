using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        // Getting the letter grade

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade >=70)
        {
            letter = "C";
        }
        else if (grade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Getting the sign

        int lastDigit = grade % 10;
        string sign = "";

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("We're sorry, you can do better next time. Keep going!");
        }
    }
}