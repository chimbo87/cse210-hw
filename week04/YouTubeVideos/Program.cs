class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create 4 videos
        Video video1 = new Video("C# Programming Basics", "Tech Tutor", 1200);
        Video video2 = new Video("Learn Object-Oriented Programming", "Code Academy", 1800);
        Video video3 = new Video("Advanced C# Techniques", "Pro Programmer", 2400);
        Video video4 = new Video("Introduction to Abstraction", "Learning Hub", 900);

        // Add comments to video1
        video1.AddComment(new Comment("John Doe", "Great tutorial for beginners!"));
        video1.AddComment(new Comment("Jane Smith", "Very clear explanation of concepts."));
        video1.AddComment(new Comment("Mike Johnson", "Helped me understand C# fundamentals."));

        // Add comments to video2
        video2.AddComment(new Comment("Sarah Lee", "Excellent overview of OOP principles."));
        video2.AddComment(new Comment("Tom Brown", "Really appreciate the detailed examples."));
        video2.AddComment(new Comment("Emma Wilson", "This video changed my understanding of programming."));

        // Add comments to video3
        video3.AddComment(new Comment("Alex Rodriguez", "Advanced techniques explained simply."));
        video3.AddComment(new Comment("Lisa Chen", "Learned so much from this video!"));
        video3.AddComment(new Comment("David Kim", "Great content for intermediate programmers."));

        // Add comments to video4
        video4.AddComment(new Comment("Emily Wong", "Abstraction was always confusing, but now it makes sense."));
        video4.AddComment(new Comment("Ryan Parker", "Clear and concise explanation."));
        video4.AddComment(new Comment("Sophia Martinez", "Excellent breakdown of abstract concepts."));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Iterate through videos and display information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); // Extra line for readability between videos
        }
    }
}