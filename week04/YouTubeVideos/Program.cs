using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all the videos.
        List<Video> videos = new List<Video>();

        // Create the first video object.
        Video video1 = new Video("C# Encapsulation Explained", "Code With Mosh", 600);
        
        // Create and add comments for the first video.
        video1.AddComment(new Comment { _commenterName = "Alice", _commentText = "This explanation is very clear!" });
        video1.AddComment(new Comment { _commenterName = "Bob", _commentText = "Thanks for the great tutorial." });
        video1.AddComment(new Comment { _commenterName = "Charlie", _commentText = "I have a question about properties. Can you make a video on that?" });
        videos.Add(video1);

        // Create the second video object.
        Video video2 = new Video("Introduction to OOP", "Programming with Jay", 900);

        // Create and add comments for the second video.
        video2.AddComment(new Comment { _commenterName = "David", _commentText = "Excellent overview of OOP principles." });
        video2.AddComment(new Comment { _commenterName = "Eve", _commentText = "Could you cover polymorphism next?" });
        video2.AddComment(new Comment { _commenterName = "Frank", _commentText = "What is the difference between abstraction and encapsulation?" });
        videos.Add(video2);

        // Create the third video object.
        Video video3 = new Video("Data Structures in C#", "The Cherno", 1200);

        // Create and add comments for the third video.
        video3.AddComment(new Comment { _commenterName = "Grace", _commentText = "The best data structures video on YouTube!" });
        video3.AddComment(new Comment { _commenterName = "Heidi", _commentText = "I learned a lot from this video, thank you." });
        videos.Add(video3);

        // Iterate through the list of videos and display their information.
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // Iterate through the comments of each video.
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
            }
        }
    }
}
