using System;

// This code creates a simple YouTube video viewer that displays the title, author, length, number of comments, and each comment for a list of videos with the execution screenshot saved as 'execution.png'.

class Program
{
    static void Main(string[] args)
    {
        // Instantiate first video object
        Video video1 = new Video();
        // Set appropriate values
        video1._title = "Video 1";
        video1._author = "Author 1";
        video1._length = 60;
        // Create comments
        Comment v1c1 = new Comment { _commentor = "John Doe", _commentText = "My intrusive thoughts agreeing!" };
        Comment v1c2 = new Comment { _commentor = "Jacob Mulan", _commentText = "I love your perspective on this." };
        Comment v1c3 = new Comment { _commentor = "Jane Cook", _commentText = "I learned a lot from this." };
        // Add comments to comment list
        video1._comments.Add(v1c1);
        video1._comments.Add(v1c2);
        video1._comments.Add(v1c3);


        // Instantiate second video object
        Video video2 = new Video();
        // Set appropriate values
        video2._title = "Video 2";
        video2._author = "Author 2";        
        video2._length = 120;
        // Create comments
        Comment v2c1 = new Comment { _commentor = "Nancy Drew", _commentText = "Could your improve on your audio?" };
        Comment v2c2 = new Comment { _commentor = "Sarah Mara", _commentText = "The points shared are valid." };
        Comment v2c3 = new Comment { _commentor = "Mickey Doe", _commentText = "I love this video!" };
        Comment v2c4 = new Comment { _commentor = "Jane Doe", _commentText = "This is a great video!" };
        // Add comments to comment list
        video2._comments.Add(v2c1);
        video2._comments.Add(v2c2); 
        video2._comments.Add(v2c3);
        video2._comments.Add(v2c4);


        Video video3 = new Video();
        // Set appropriate values
        video3._title = "Video 3";
        video3._author = "Author 3";
        video3._length = 180;
        // Create comments
        Comment v3c1 = new Comment { _commentor = "Sally Marley", _commentText = "How insightful!" };
        Comment v3c2 = new Comment { _commentor = "Dawson Lawson", _commentText = "This was very informative." };
        Comment v3c3 = new Comment { _commentor = "Mary Jane", _commentText = "Great video!" };
        // Add comments to comment list
        video3._comments.Add(v3c1);
        video3._comments.Add(v3c2); 
        video3._comments.Add(v3c3);

        // Create a list of videos and add the video objects to the list
        List<Video> videos = [video1, video2, video3];  

        Console.WriteLine("\nWelcome to the YouTube Video Viewer!\n");
        // Loop through each video in the list and display its details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}\nAuthor: {video._author}\nLength: {video._length} seconds\nNumber of comments: {video.GetCommentsCount()}");

            // Display each comment for the video
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                comment.DisplayComment();
            }
            Console.WriteLine(); // Add a blank line between videos
        }
    }
}