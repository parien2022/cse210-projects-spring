public abstract class Goal {

    private String _name;
    private String _description;
    private int _points;
    public Goal (String name, String description, int points){
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent ();
    public abstract bool IsComplete();

    public virtual String GetDetailsString(){
        return $"[ ] {_name} ({_description})";
    }
    public abstract String GetStringRepresentation ();

    public String getName(){
        return _name;
    }
    public String getDescription(){
        return _description;
    }
    public int getPoints(){
        return _points;
    }

    public void setPointsBonus(int bonus){
        _points = _points + bonus;
    }


}