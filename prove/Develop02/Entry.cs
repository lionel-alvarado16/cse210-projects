using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public void DisplayEntry()
    {
        DateTime currentTime = DateTime.Now;
        string _date = currentTime.ToShortDateString();

        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
    }
}