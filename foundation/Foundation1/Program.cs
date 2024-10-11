using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        Video video1 = new Video("How to Program in C#", "John Smith", 360);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Carlos", "Very informative, thanks!"));
        video1.AddComment(new Comment("Maria", "Loved the content."));

        Video video2 = new Video("Learning Python", "Maria Johnson", 420);
        video2.AddComment(new Comment("Peter", "Excellent!"));
        video2.AddComment(new Comment("Anna", "Super useful!"));
        video2.AddComment(new Comment("Lucas", "I loved it!"));

        Video video3 = new Video("JavaScript Tips", "Paula Davis", 300);
        video3.AddComment(new Comment("Robert", "I liked the tips!"));
        video3.AddComment(new Comment("Julia", "Very good!"));

        // Adding videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterating through the list of videos
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.Duration} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            // Listing comments
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // Blank line for separation
        }
    }
}
