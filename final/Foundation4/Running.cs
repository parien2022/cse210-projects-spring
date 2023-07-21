public class Running : Activity {

    private double _distance;

    public Running (String date, double lengthMinutes, double distance) : base(date, lengthMinutes){
        _distance = distance;
    }

    public override double performDistanceCalculation()
    {
        return _distance;
    }

    public override double performSpeedCalculation()
    {
        return (_distance / getLength()) * 60;
    }

    public override double performPaceCalculation()
    {
        return 60 / performSpeedCalculation();
    }
}