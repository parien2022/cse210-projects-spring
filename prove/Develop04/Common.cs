public class Common {

    private String _name;
    private String _description;
    private String _time;

    private String[] _sppinerList = {"-", "\\", "|", "/", "-", "\\", "|"};
    private String[] _countList = {"6", "5", "4","3", "2", "1", "0", ""};


    public Common(String name, String description) {

        _name = name;
        _description = description;
    
    }
    public String getName() {
        return $"Welcome to the {_name} activity\n";
    }

    public String getDescription() {
        return $"{_description}\n";
    }

    public void setTime (){
        Console.Write("How long, in seconds, would you like your session? ");
        _time = Console.ReadLine();
    }

    public String getTime(){
        return _time;
    }

    public void getFirstMessage() {
        Console.WriteLine("Get Ready");
        animation(3, _sppinerList, 500);
    }

    public void getLastMessage() {
        Console.WriteLine("");
        Console.WriteLine("\nWell Done!!");
        animation(0, _sppinerList, 800);
        Console.WriteLine("");
        Console.WriteLine($"\nYou have completed another {_time} seconds of the {_name} activity");
        animation(0, _sppinerList, 800);
    }

    public String[] getCountList (){
        return _countList;
    }

    public String[] getSpinnerList (){
        return _sppinerList;
    }

    public void animation(int startCount, String [] list, int last){

        for (int i = startCount; i < list.Length; i++){
                Thread.Sleep(last);
                Console.Write("\b");
                Console.Write(list[i]);
            }
    }
}