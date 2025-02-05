using System;
using System.Collections.Generic;


// CSE210 Programming with Classes.
// Cherry Machado.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("");

        //Create a list to store videos
        List<Video> videos = new List<Video>();

        //Create and populate the first video
        Video video1 = new Video("C# Programming Basics", "Tech Guru", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial! Very clear explanations."));
            video1.AddComment(new Comment("Bob", "Could you cover async programming next?"));
            video1.AddComment(new Comment("Charlie", "Thanks for sharing this!"));

            // Create and populate the second video
            Video video2 = new Video("Advanced C# Techniques", "Code Master", 900);
            video2.AddComment(new Comment("David", "This was incredibly helpful!"));
            video2.AddComment(new Comment("Eve", "I learned so much from this video."));
            video2.AddComment(new Comment("Frank", "Can you make more like this?"));

            // Create and populate the third video
            Video video3 = new Video("Introduction to LINQ", "Data Wizard", 450);
            video3.AddComment(new Comment("Grace", "LINQ is amazing! Thanks for the intro."));
            video3.AddComment(new Comment("Heidi", "This helped me understand LINQ better."));
            video3.AddComment(new Comment("Ivan", "Looking forward to more content like this."));

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            //Iterate through the list and display each video's details
            foreach (var video in videos)
            {
                video.DisplayVideoDetails();
            }
    }
}