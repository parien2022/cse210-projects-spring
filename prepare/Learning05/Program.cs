using System;

class Program
{
    static void Main(string[] args)
    {

        Square square = new Square("Blue", 5);
        Rectangle rectangle = new Rectangle("Yellow", 6, 2);
        Circle circle  = new Circle("Red", 8);

        List<Shape> shapeList = new List<Shape>();

        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList){
            Console.WriteLine(shape.GetColor());
            Console.WriteLine($"Area: {shape.GetArea()}");
        }

    }
}