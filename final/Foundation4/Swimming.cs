public class Swimming : Activity {

    private double _lapsAmount;

    public Swimming(String date, double lengthMinutes, double lapsAmount) : base(date, lengthMinutes){
        _lapsAmount = lapsAmount;
    }

    public override double performDistanceCalculation()
    {
        return _lapsAmount * 50 / 1000;
    }

    public override double performSpeedCalculation()
    {
        return (performDistanceCalculation() / getLength()) * 60;
    }

    public override double performPaceCalculation()
    {
        return 60 / performSpeedCalculation();
    }
}