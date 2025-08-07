// Video.cs
using System;
using System.Collections.Generic;

public class YouTubeVideo
{
    // Properties for the video's details.
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }

    // A private list to store the comments.
    // The private keyword ensures that the list can only be accessed
    // and modified from within the Video class itself.
    private List<Comment> Comments { get; } = new List<Comment>();

    // This is a constructor. It's used to create a new Video object.
    public YouTubeVideo(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // A method to add a new comment to the video's list.
    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    // A method to get the total number of comments on the video.
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // This method is for displaying the video's information to the console.
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
    }
}