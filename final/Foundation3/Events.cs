public class Events {

    private String _title;
    private String _description;
    private String _date;
    private String _time;
    private Address _address;
    public Events(String title, String description, String date, String time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void getStandardDetails(){
        Console.WriteLine();
        Console.WriteLine("******* EVENT ********");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date}     {_time}");
        Console.WriteLine(_address.getCompleteAddress());
    }

    public void getShortDescription(){
        Console.WriteLine("----------Description---------");
        Console.WriteLine($"Type of event: {this.GetType().Name}");
        Console.WriteLine($"Title: {_title}   Date: {_date}");
        Console.WriteLine();
        Console.WriteLine("-------------------------------");
    }
}