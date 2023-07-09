public class MathAssignment : Assignment {

    private String _textBookSection;
    private String _problems;
    public MathAssignment (String name , String topic, String textBook, String problems) : base(name, topic){

        _textBookSection = textBook;

        _problems = problems;

    }


    public String GetHomeworkList() {

        return $"Section {_textBookSection} Problems {_problems}";
    }
}