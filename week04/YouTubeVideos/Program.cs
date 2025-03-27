using System;
using System.Collections.Generic;

// Comment class to represent individual comments
public class Comment
{
    // Properties for commenter name and comment text
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor to initialize a comment
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

// Video class to represent YouTube videos
public class Video
{
    // Properties for video details
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    // List to store comments for the video
    private List<Comment> Comments { get; set; }

    // Constructor to initialize a video
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to return the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display all comments for the video
    public void DisplayComments()
    {
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"Commenter: {comment.CommenterName}");
            Console.WriteLine($"Comment: {comment.CommentText}");
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video("Coding Basics", "TechTutor", 1200);
        video1.AddComment(new Comment("JavaFan", "Great tutorial!"));
        video1.AddComment(new Comment("CodeNinja", "Very helpful explanation."));
        video1.AddComment(new Comment("WebDev", "Learned a lot from this."));
        videos.Add(video1);

        // Create second video
        Video video2 = new Video("Machine Learning Intro", "AI Experts", 1800);
        video2.AddComment(new Comment("DataScientist", "Excellent overview."));
        video2.AddComment(new Comment("AIEnthusiast", "Inspiring content!"));
        video2.AddComment(new Comment("StudentLearner", "Complex topic explained simply."));
        videos.Add(video2);

        // Create third video
        Video video3 = new Video("Web Development Trends", "DevGuru", 1500);
        video3.AddComment(new Comment("FrontEndDev", "Current trends explained well."));
        video3.AddComment(new Comment("FullStackCoder", "Comprehensive breakdown."));
        video3.AddComment(new Comment("UIDesigner", "Great insights!"));
        videos.Add(video3);

        // Iterate through videos and display details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("\nComments:");
            video.DisplayComments();
            
            // Add a separator between videos
            Console.WriteLine("----------------------------");
        }
    }
}