public class Shape {

    private String _color;

    public Shape (String color){
        _color = color;
    }

    public void SetColor (String color){
        _color = color;
    }

    public String GetColor (){
        return _color;
    }

    public virtual float GetArea (){
        return 0;
    }
}