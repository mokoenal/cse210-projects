using System;
using System.Collections.Generic;
using System.Linq;

// Class to encapsulate the responsibilities of a Scripture
public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0)
                break;
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference} - {string.Join(" ", Words)}";
    }
}
