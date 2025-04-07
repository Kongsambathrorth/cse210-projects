using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> Comments { get; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

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

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Chinese fighting", "Chinlong", 300),
            new Video("Game is oover", "Sivlong", 450)
        };

        videos[0].AddComment("Dara", "Great explanation!");
        videos[0].AddComment("Thida", "Good content");
        videos[1].AddComment("Yeng", "Very informative.");
        videos[1].AddComment("Dana", "Good action and performance!");

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}