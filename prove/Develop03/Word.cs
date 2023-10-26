using System;
using System.Collections.Generic;

 public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false; // By default, the word is not hidden.
    }

    public string Text
    {
        get { return _text; }
    }

    public bool Hidden
    {
        get { return _hidden; }
        set { _hidden = value; }
    }
}










