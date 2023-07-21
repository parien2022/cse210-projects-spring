public class Cycling : Activity {

    private double _speed;

    public Cycling(String date, double lengthMinutes, double speed) : base(date, lengthMinutes){
        _speed = speed;
    }

    public override double performDistanceCalculation()
    {
        return _speed * getLength() / 60;
    }

    public override double performSpeedCalculation()
    {
        return _speed;
    }

    public override double performPaceCalculation()
    {
        return 60 / _speed;
    }
}