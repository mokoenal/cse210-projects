using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommentDetails()
    {
        return $"Commenter: {_commenterName}, Text: {_text}";
    }
}