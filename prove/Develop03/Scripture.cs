using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();

        // Initialize the list of words from the text (split the text into words).
        string[] textWords = _text.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in textWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void Display()
    {
    Console.WriteLine($"{_reference.Chapter}:{_reference.StartVerse} {_text}");
    Console.WriteLine();

    foreach (Word word in _words)
    {
        Console.Write(word.Hidden ? "---- " : word.Text + " ");
    }
    Console.WriteLine();
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.FindAll(word => !word.Hidden);

        if (unhiddenWords.Count > 0)
        {
            int randomIndex = random.Next(unhiddenWords.Count);
            unhiddenWords[randomIndex].Hidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(word => word.Hidden);
    }
}
