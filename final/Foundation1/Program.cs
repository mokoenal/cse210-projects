using System;

class Program
{
    static void Main(string[] args)

    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create instances of Video and add comments
        Video video1 = new Video("Funny Cat Compilation", "CrazyCatLady", 180);
        video1.AddComment("Lindiwe", "Hilarious! I can't stop laughing.");
        video1.AddComment("Colletta", "Best cat video ever!");
        video1.AddComment("Lunga", "Love this!");

        Video video2 = new Video("Travel Vlog: African Adventure", "TravelExplorer", 600);
        video2.AddComment("Thandi", "Amazing video! I felt like I was in Africa.");
        video2.AddComment("Oscar", "Wow, can't wait to visit Africa someday!.");
        video2.AddComment("Bianca", "Never Knew Africa was so Beautiful, I Love it!.");

        Video video3 = new Video("Programming Tips and Tricks", "CodeMaster", 420);
        video3.AddComment("Ntombi", "Great tips! Very helpful.");
        video3.AddComment("Lebo", "This helped me solve a coding challenge.");
        video3.AddComment("Connie", "Thank you so much, your videos are so easy to comprehend.");


        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list and display details for each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}