public class Video
{
    private string _title;
    private string _authour;
    private int _lengeth;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string authour, int length)
    {
        _title = title;
        _authour = authour;
        _lengeth = length;

    }
    public void AddComment(Comment C)
    {
        
        _comments.Add(C);
    }
    public void Display()
    {
        Console.WriteLine($"Title-{_title} Authour-{_authour} Lengeth-{_lengeth}-seconds \n comments: ");
        foreach (Comment i in _comments)
        {
            Console.Write($" {i}");
        }
    }
}