using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Video 1 Setup
            Video video1 = new Video("C# Basics for Beginners", "TechAcademy", 720);
            video1.AddComment(new Comment("Alice Smith", "This cleared up so many doubts I had. Thank you!"));
            video1.AddComment(new Comment("Bob Jones", "Excellent pacing. Highly recommended for absolute beginners."));
            video1.AddComment(new Comment("Charlie Brown", "Can you make a follow-up video on Object-Oriented Programming?"));
            videos.Add(video1);

            // Video 2 Setup
            Video video2 = new Video("How to Build a Custom Mechanical Keyboard", "KeyClackers", 1050);
            video2.AddComment(new Comment("Dave Miller", "The sound test at the end was pure ASMR."));
            video2.AddComment(new Comment("Emily Davis", "Where did you buy those keycaps? They look incredible."));
            video2.AddComment(new Comment("Frank Wilson", "Instructions were perfectly clear, just ordered my first kit!"));
            videos.Add(video2);

            // Video 3 Setup
            Video video3 = new Video("Top 10 Productivity Apps for Students", "StudySmart", 540);
            video3.AddComment(new Comment("Grace Hopper", "Using the second app completely changed my study routine."));
            video3.AddComment(new Comment("Henry Cavil", "Is there a completely free alternative to the third option?"));
            video3.AddComment(new Comment("Ivy League", "Great compilation, saving this for next semester."));
            videos.Add(video3);

            // Print Pipeline (Iterating and presenting values directly)
            foreach (Video video in videos)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine($"Title:  {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Total Comments: {video.GetCommentCount()}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
                }
                Console.WriteLine("==================================================\n");
            }
        }
    }
}