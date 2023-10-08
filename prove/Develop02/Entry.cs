using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    public string _time;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine($"Time: {_time}");
    }
}