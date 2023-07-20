public class Comments {

    private String _name;

    private String _comment;
    
    public void setComment( String name, String comment){
        _name = name;
        _comment = comment;
    }

    public String getComment(){
        return $"{_name}: {_comment}";
    }
}