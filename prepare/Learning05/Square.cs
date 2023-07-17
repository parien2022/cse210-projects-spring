public class Square : Shape {

    private int _side;

    public Square (String color, int side) : base (color) {
        _side = side;
    }

    public override float GetArea()
    {
        return _side * _side;
    }
}