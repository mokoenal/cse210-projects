using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string reference)
    {
        // Parse the reference (e.g., "John 3:16" or "Proverbs 3:5-6") and set the fields.
        string[] parts = reference.Split(' ');
        if (parts.Length >= 2)
        {
            _book = parts[0];

            string[] chapterVerse = parts[1].Split(':');
            if (chapterVerse.Length == 2)
            {
                if (int.TryParse(chapterVerse[0], out _chapter) && int.TryParse(chapterVerse[1], out _startVerse))
                {
                    // Check if it's a range (e.g., "Proverbs 3:5-6").
                    if (_startVerse.ToString() == chapterVerse[1])
                    {
                        _endVerse = _startVerse;
                    }
                    else
                    {
                        // If it's a range, parse the end verse.
                        string[] verseRange = chapterVerse[1].Split('-');
                        if (verseRange.Length == 2 && int.TryParse(verseRange[1], out _endVerse))
                        {
                            _startVerse = int.Parse(verseRange[0]);
                        }
                    }
                }
            }
        }
    }

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Book
    {
        get { return _book; }
    }

    public int Chapter
    {
        get { return _chapter; }
    }

    public int StartVerse
    {
        get { return _startVerse; }
    }

    public int EndVerse
    {
        get { return _endVerse; }
    }
}