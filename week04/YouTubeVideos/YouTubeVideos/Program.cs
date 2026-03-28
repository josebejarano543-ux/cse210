using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Buy a Used Car", "Jose", 300);
        video1.AddComment(new Comment("Luis", "Very helpful!"));
        video1.AddComment(new Comment("Maria", "Thanks bro!"));
        video1.AddComment(new Comment("Carlos", "Nice tips"));
        videos.Add(video1);

        Video video2 = new Video("Car Inspection Tips", "AutoExpert", 420);
        video2.AddComment(new Comment("Ana", "I learned a lot"));
        video2.AddComment(new Comment("Pedro", "Good video"));
        video2.AddComment(new Comment("Sofia", "Clear explanation"));
        videos.Add(video2);

        Video video3 = new Video("Top 5 Cheap Cars", "CarsDaily", 250);
        video3.AddComment(new Comment("Miguel", "Great list"));
        video3.AddComment(new Comment("Laura", "I want one!"));
        video3.AddComment(new Comment("David", "Nice video"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine("------------------------");
        }
    }
}