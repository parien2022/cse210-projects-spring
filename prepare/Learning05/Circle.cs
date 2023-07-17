public class Circle : Shape {

    private int _radius;

    public Circle (String color, int raduis) : base (color) {
        _radius = raduis;
    }

    public override float GetArea()
    {
        return (float)(Math.PI * Math.Pow(_radius, 2));
    }
}