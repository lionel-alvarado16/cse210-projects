using System;

public class ReflectionActivity : Activity
{
    private int _duration;
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public ReflectionActivity()
    {
        SetName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _duration = 50;
        SetDuration(_duration);

        List<string> prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _prompts = prompts;

        List<string> questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _questions = questions;
    }
    
    public void Activity1()
    {
        Random choosePrompt = new Random();
        int index = choosePrompt.Next(_prompts.Count);
        string prompt = _prompts[index];

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        if (userInput == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            PausingShowingCountdownTimer(3);
        }
    }

    public void Activity2()
    {
        Random chooseQuestion = new Random();
        int index = chooseQuestion.Next(_questions.Count);
        string prompt = _questions[index];
        _questions.RemoveAt(index);

        Console.Write($"> {prompt} ");
        PausingShowingSpinner(10);
        Console.WriteLine();
    }
    
    public void Activity()
    {
        DateTime start = DateTime.Now;
        _duration = GetDuration();
        DateTime end = start.AddSeconds(_duration);

        Activity1();
        Console.Clear();

        while (DateTime.Now < end)
        {
            Activity2();
        }

        Console.WriteLine();
    }

    public void RunActivity()
    {
        StartingMessage();
        Activity();
        EndingMessage();
    }
}