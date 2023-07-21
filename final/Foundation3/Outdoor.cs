public class Outdoor : Events {

    private String _wather;

    public Outdoor(String name, String description, String date, String time, Address address, String wather) : base (name, description, date, time, address){
        _wather = wather;
    }


    public void getOutdoorsInfo(){
        Console.WriteLine($"Forecast: {_wather}");
    }
}