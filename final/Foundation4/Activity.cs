public class Activity {

    private String _date;
    private double _lengthMinutes;

    public Activity(String date, double lengthMinutes){
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public double getLength(){
        return _lengthMinutes;
    }

    public virtual double performDistanceCalculation(){
        return 0;
    }

    public virtual double performSpeedCalculation(){
        return 0;
    }

    public virtual double performPaceCalculation(){
        return 0;
    }

    public void getSummary(){
        Console.WriteLine();
        Console.WriteLine($"************ {this.GetType().Name} *************");
        Console.WriteLine($"{_date} {this.GetType().Name} ({_lengthMinutes} min)- Distance {performDistanceCalculation()} km, Speed {performSpeedCalculation()} kph, Pace: {performPaceCalculation()} min per km");
        Console.WriteLine("-------------------------------------------------");
    }


}