public class Receptions : Events {

    private String _emailRSVP;

    public Receptions(String name, String description, String date, String time, Address address, String emailRSVP) : base (name, description, date, time, address){
        _emailRSVP = emailRSVP;
    }


    public void getReceptionsInfo(){
        Console.WriteLine($"Email for RSVP: {_emailRSVP}");
    }
}