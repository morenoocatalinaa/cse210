using System;

public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video
        {
            Title = "C# Tutorial",
            Author = "John Doe",
            Length = 15
        };
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "I learned a lot."));

        Video video2 = new Video
        {
            Title = "Learn LINQ",
            Author = "Jane Smith",
            Length = 20
        };
        video2.AddComment(new Comment("Charlie", "Very informative!"));

        Video video3 = new Video
        {
            Title = "Mastering Arrays",
            Author = "Bob Johnson",
            Length = 25
        };
        video3.AddComment(new Comment("David", "Clear explanation!"));

        Console.WriteLine($"Title: {video1.Title}, Author: {video1.Author}, Length: {video1.Length} mins");
        Console.WriteLine($"Number of Comments: {video1.GetCommentCount()}");
        foreach (var comment in video1.GetComments())
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
        Console.WriteLine();

        Console.WriteLine($"Title: {video2.Title}, Author: {video2.Author}, Length: {video2.Length} mins");
        Console.WriteLine($"Number of Comments: {video2.GetCommentCount()}");
        foreach (var comment in video2.GetComments())
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
        Console.WriteLine();

        Console.WriteLine($"Title: {video3.Title}, Author: {video3.Author}, Length: {video3.Length} mins");
        Console.WriteLine($"Number of Comments: {video3.GetCommentCount()}");
        foreach (var comment in video3.GetComments())
        {
            Console.WriteLine($"{comment.Name}: {comment.Text}");
        }
    }
}
