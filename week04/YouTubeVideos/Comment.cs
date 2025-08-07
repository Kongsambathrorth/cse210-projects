// Comment.cs
using System;

public class VideoComment
{
    // Properties to store the name of the commenter and the comment text.
    public string CommenterName { get; }
    public string Text { get; }

    // This is a constructor. It's used to create a new VideoComment object
    // and set its initial values for CommenterName and Text.
    public VideoComment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}