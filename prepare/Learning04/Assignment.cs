public class Assignment {

    private String _name;
    private String _topic;


    public Assignment (String name, String topic){

        _name = name;

        _topic = topic;

    }

    public String GetStudentName (){
        return _name;
    }

    public String GetSummary(){

        return _name + " - " + _topic;

    }

}