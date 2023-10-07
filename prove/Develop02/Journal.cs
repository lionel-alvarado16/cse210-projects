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