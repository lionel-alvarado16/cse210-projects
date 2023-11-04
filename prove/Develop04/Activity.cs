using System;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    public Activity()
    { }
    
    // public Activity(string activityName, string activityDescription, int activityDuration)
    // {
    //     _activityName = activityName;
    //     _activityDescription = activityDescription;
    //     _activityDuration = activityDuration;
    // }

    public void SetName(string name)
    {
        _activityName = name;
    }

    public void SetDescription(string description)
    {
        _activityDescription = description;
    }

    public void SetDuration(int duration)
    {
        _activityDuration = duration;
    }

    public int GetDuration()
    {
        return _activityDuration;
    }

    public void PausingShowingSpinner(int time)
    {
        List<string> animationCharacters = new List<string>();
        animationCharacters.Add("|");
        animationCharacters.Add("/");
        animationCharacters.Add("—");
        animationCharacters.Add("\\");
        animationCharacters.Add("|");
        animationCharacters.Add("/");
        animationCharacters.Add("—");
        animationCharacters.Add("\\");
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < end)
        {
            string character = animationCharacters[i];
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationCharacters.Count)
            {
                i = 0;
            }
        }
    }

    public void PausingShowingCountdownTimer(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for the session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        PausingShowingSpinner(7);
        Console.WriteLine();
    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!!");
        PausingShowingSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
        PausingShowingSpinner(5);
        Console.Clear();
    }
}