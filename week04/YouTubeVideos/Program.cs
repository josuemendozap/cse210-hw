using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();


        Video video1 = new Video("Amazing Cat Tricks", "CatLover123", 210);
        video1.AddComment(new Comment("John", "This cat is amazing!"));
        video1.AddComment(new Comment("Emily", "I love the jump trick."));
        video1.AddComment(new Comment("Chris", "So cute!"));
        videos.Add(video1);


        Video video2 = new Video("How to Bake Bread", "BakingWithJoy", 480);
        video2.AddComment(new Comment("Sarah", "This helped me a lot!"));
        video2.AddComment(new Comment("Daniel", "Looks delicious."));
        video2.AddComment(new Comment("Linda", "I tried it, came out great!"));
        videos.Add(video2);


        Video video3 = new Video("Top 10 Travel Destinations", "ExplorerMike", 600);
        video3.AddComment(new Comment("Alex", "I want to visit #4 so badly."));
        video3.AddComment(new Comment("Priya", "Great video!"));
        video3.AddComment(new Comment("Tom", "Adding these to my bucket list."));
        video3.AddComment(new Comment("Olivia", "Awesome recommendations."));
        videos.Add(video3);


        Video video4 = new Video("Learn C# in 10 Minutes", "CodeMaster", 590);
        video4.AddComment(new Comment("Maria", "Very helpful overview."));
        video4.AddComment(new Comment("Kevin", "Clear explanation! Thanks."));
        video4.AddComment(new Comment("Jake", "Exactly what I needed."));
        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}