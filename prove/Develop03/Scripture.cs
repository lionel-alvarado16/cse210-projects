using System;

public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string textScripture)
    {
        _reference = reference;

    }
}