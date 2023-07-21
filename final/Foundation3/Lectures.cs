public class Lectures : Events {

    private String _speakerName;
    private int _capacity;
    public Lectures (String name, String description, String date, String time, Address address, String speakerName, int capacity) : base (name, description, date, time, address){
        _speakerName = speakerName;
        _capacity = capacity;
    }


    public void getLectureInfo(){
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Max capacity is {_capacity}");
    }
}