public class WritingAssignment : Assignment {

    private String _title;

    public WritingAssignment (String name, String topic, String title) : base(name, topic){

        _title = title;
    }

    public String GetWritingInformation (){

        String name = GetStudentName();

        return $"{_title} by {name}";
    }
}