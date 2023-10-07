using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random promptGenerator = new Random();
        int index = promptGenerator.Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine(prompt);

        Entry newEntry = new Entry();
        newEntry._prompt = prompt;
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
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            
            Entry newEntry = new Entry();     
            newEntry._prompt = parts[0];
            newEntry._entry = parts[1];
            _entries.Add(newEntry);
        }

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
                outputFile.WriteLine($"{ent._prompt}~{ent._entry}");
            }
        }
    }
}