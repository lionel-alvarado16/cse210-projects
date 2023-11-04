using System;

public class ListingActivity : Activity
{
    private int _duration;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _duration = 50;
        SetDuration(_duration);

        List<string> prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _prompts = prompts;
    }

    public void Activity()
    {
        DateTime start = DateTime.Now;
        _duration = GetDuration();
        DateTime end = start.AddSeconds(_duration);

        List<string> responses = new List<string>();
            
        Random choosePrompt = new Random();
        int index = choosePrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
            
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        PausingShowingCountdownTimer(5);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        int elements = responses.Count;
        Console.WriteLine($"You listed {elements} items.");
        Console.WriteLine();
    }

    public void RunActivity()
    {
        StartingMessage();
        Activity();
        EndingMessage();
    }
}