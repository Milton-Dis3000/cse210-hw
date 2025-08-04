using System.Collections.Generic;

// Class that represents a single YouTube video.
public class Video
{
    // Private attributes for video details.
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    
    // A list to hold the comments for this video.
    public List<Comment> _comments = new List<Comment>();

    // Constructor to initialize the video attributes.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    // Method to get the total number of comments on the video.
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to add a new comment to the list.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}
