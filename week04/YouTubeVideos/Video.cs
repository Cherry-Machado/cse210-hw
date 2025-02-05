using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    //Method to get the number of comments
    public int GetNumbersOfComments()
    {
        return _comments.Count;
    }

    // Method to display video details and its comments
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumbersOfComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine(new string('-', 50));
    }
}