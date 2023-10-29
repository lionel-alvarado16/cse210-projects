using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _hiddenWords = new List<Word>();

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

    public void HideWords()
    {
        List<Word> hiddenWords = new List<Word>();
        
        Random hideWords = new Random();

        while (hiddenWords.Count < 3)
        {
            int index = hideWords.Next(_words.Count);

            if (_hiddenWords.Contains(_words[index]) == false)
            {
                hiddenWords.Add(_words[index]);
                _hiddenWords.Add(_words[index]);
                if (_words.Count == _hiddenWords.Count)
                {
                    break;
                }
            }
        }
    }

    public void GetRenderedText()
    {
        Console.Clear();
        Console.Write($"{_reference} ");

        foreach (Word w in _words)
        {
            if (_hiddenWords.Contains(w) == false)
            {
                w.ShowWord();
            }
            else if (_hiddenWords.Contains(w) == true)
            {
                w.HideWord();
            }
        }

        Console.WriteLine();
    }

    public bool CompletelyHidden()
    {      
        bool result = _words.Count == _hiddenWords.Count;
        return result;
    }
}