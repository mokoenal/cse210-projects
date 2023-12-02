using System;
using System.Collections.Generic;

public class Comment
{
    private string CommenterName;
    private string Text;

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
    public string GetCommentDetails()
    {

        return $"{CommenterName} : {Text}";
    }

}