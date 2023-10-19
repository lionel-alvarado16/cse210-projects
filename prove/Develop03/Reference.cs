using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = 0;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        string reference = "";

        if (_verseEnd == 0)
        {
            reference = $"{_book} {_chapter}:{_verseStart}";
        }
        
        if (_verseEnd != 0)
        {
            reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }

        return reference;
    }
}