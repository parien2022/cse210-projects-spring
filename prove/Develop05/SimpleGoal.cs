public class SimpleGoal : Goal {

    private bool _isComplete;

    public SimpleGoal (String name, String description, int points, bool isComplete) : base (name, description, points){
        _isComplete = isComplete;
    }

    public override void RecordEvent(){
        IsComplete();
    }

    public override String GetDetailsString(){
        String name = getName();
        String description = getDescription();
        String check = _isComplete ? "X" : " ";
        return $"[{check}] {name} ({description})";
    }

    public override bool IsComplete(){
        if (!_isComplete){
            _isComplete = true;
            return _isComplete;
        }
        return false;
    }

    public override string GetStringRepresentation() {
        String name = getName();
        String description = getDescription();
        int points = getPoints();
        return $"SimpleGoal:{name},{description},{points}, {_isComplete}";
    }
}