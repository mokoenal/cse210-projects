using System;
using System.Collections.Generic;
using System.Linq;

// Class to encapsulate the responsibilities of a Word
public class Word
{
    private string _text;
    public string Text
    {
        get { return _text; }
        private set { _text = value; }
    }

    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "_____" : Text;
    }
}




