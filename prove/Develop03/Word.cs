using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string textWord)
    {
        _word = textWord;
        _hidden = true;
    }

    public void ShowWord()
    {
        Console.Write($"{_word} ");
    }

    public void HideWord()
    {
        foreach (char letter in _word)
        {
            Console.Write("_");
        }
    }
}