using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string textScripture)
    {
        _reference = reference;

        List<Word> words = new List<Word>();

        string[] parts = textScripture.Split(" ");

        foreach (string word in parts)
        {
            Word newWord = new Word(word);
            words.Add(newWord);
        }

        _words = words;
    }

    public void GetRenderedText()
    {
        Console.Clear();
        Console.Write($"{_reference} ");
        foreach (Word w in _words)
        {
            w.ShowWord();
        }
        Console.WriteLine();
    }

    public void HideWords()
    {
        
    }
}