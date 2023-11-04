using System;

public class BreathingActivity : Activity
{  
    private int _duration;
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        _duration = 50;
        SetDuration(_duration);
    }

    public void Activity()
    {
        DateTime start = DateTime.Now;
        _duration = GetDuration();
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breath in...");
            PausingShowingCountdownTimer(4);
            Console.Write("Now breathe out...");
            PausingShowingCountdownTimer(6);
            Console.WriteLine();
        }
    }

    public void RunActivity()
    {
        StartingMessage();
        Activity();
        EndingMessage();
    }
}