using System;
using System.Collections.Generic;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    //Method to display the comment
    public void DisplayComment()
    {
        Console.WriteLine($"  - {_commenterName}: \"{_commentText}\"");
    }

}