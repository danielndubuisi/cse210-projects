public class Video
{
    // attributes
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    // method
    public int GetCommentsCount()
    {
        // returns the number of comments on this video
        return _comments.Count;
    }

}