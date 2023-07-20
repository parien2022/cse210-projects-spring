public class Video {

    private String _title;
    private String _author;
    private int _length;

    private List<String> _commentList = new List<String> ();

    public Video (String title, String author, int length){
        _title =  title;
        _author = author;
        _length = length;
    }

    public void addCommentList(String comment){
        _commentList.Add(comment);
    }

    public void getVideoInfo (){
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Seconds: {_length}");
    }

    public String getNumberOfComments (){
        return $"Number of comments: {_commentList.Count()}";
    }

    public List<String> getCommentList (){
        return _commentList;
    }
}