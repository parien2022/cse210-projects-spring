public class Breathing : Common {

    public Breathing (String name, String description) : base (name, description){
    }

    public void inAndOut(){

        String time = getTime();
        int seconds = int.Parse(time);
        int last = 1000;
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        String[] countList = getCountList();
        String [] spinnerList = getSpinnerList();

        while (startTime < futureTime){
            
            Console.Write("\nBreath in... ");
            animation(4, countList, last);

            Console.Write("\nNow breath out... ");
            animation(3, countList, last);

            startTime = DateTime.Now;
        }
    }
}