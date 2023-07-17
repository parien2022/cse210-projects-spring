public class Rectangle : Shape {

    private int _length;
    private int _width;

    public Rectangle (String color, int length, int width) : base (color){
        _length = length;
        _width = width;
    }


    public override float GetArea()
    {
        return _length * _width;
    }
}