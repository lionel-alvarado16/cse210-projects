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
        if (_hidden == true)
        {
            Console.Write($"{_word} ");
        }
    }

    public void HideWord()
    {
        _hidden = false;
        
        if (_hidden == false)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
    }
}