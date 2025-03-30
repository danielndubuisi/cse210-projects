public class Comment
{
    // attributes
    public string _commentor;
    public string _commentText;

    // method
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentText} - {_commentor}");
    }
}