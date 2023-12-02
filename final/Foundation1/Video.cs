using System;
using System.Collections.Generic;

public class Video
{
    private string Title;
    private string Author;
    private int LengthInSeconds;
    private List<Comment> Comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));

    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine(comment.GetCommentDetails());
        }

    }
}