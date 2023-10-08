using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string prompt = newPrompt.Prompt();
        Console.WriteLine(prompt);

        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();
        string time = currentTime.ToShortTimeString();

        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
        newEntry._date = date;
        newEntry._time = time;
        newEntry._entry = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void Display()
    {
        foreach (Entry ent in _entries)
        {
            ent.DisplayEntry();
            Console.WriteLine();
        }
    }

    public List<Entry> LoadFile()
    {
        List<Entry> savedEntries = new List<Entry>();
        
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            
            Entry newEntry = new Entry();     
            newEntry._prompt = parts[0];
            newEntry._date = parts[1];
            newEntry._time = parts[2];
            newEntry._entry = parts[3];
            savedEntries.Add(newEntry);
        }

        _entries = savedEntries;

        return _entries;
    }

    public void SaveFile()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine($"{ent._prompt}~{ent._date}~{ent._time}~{ent._entry}");
            }
        }
    }
}