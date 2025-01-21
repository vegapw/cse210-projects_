public class Video {

    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video (string title, string author, int lenght){
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public int GetNumberOfComments(){
        return _comments.Count();
    }

    public string GetDisplayText(){
        string text = $"Title: {_title}\nAuthor: {_author}\nLenght: {_lenght} Seconds\nComments:\n";
        foreach (Comment comment in _comments)
        {
            text += comment.GetDisplayText() + "\n";
        }
        return text;
    }
}