public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string Title 
    { 
        get { return _title; }
    }

    public string Author 
    { 
        get { return _author; }
    }

    public int Length 
    { 
        get { return _length; }
    }

    public List<Comment> Comments 
    { 
        get { return _comments; }
    }
}