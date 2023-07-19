public class ChecklistGoal : Goal {

    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (String name, String description, int points, int target, int bonus, int amountCompleted) : base (name, description, points){
        _target =  target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }


    public override void RecordEvent(){
        _amountCompleted = _amountCompleted + 1;
        IsComplete();
        if (IsComplete()){
            setPointsBonus(_bonus); 
        }
    }

    public override String GetDetailsString(){
        String name = getName();
        String description = getDescription();
        String check = IsComplete() ? "X" : " ";
        return $"[{check}] {name} ({description}) --- Currently completed: {_amountCompleted}/{_target}";
    }

    public override bool IsComplete(){
        if (_amountCompleted != _target){
            return false;
        } else {
            return true;
        }
    }

    public override string GetStringRepresentation() {
        String name = getName();
        String description = getDescription();
        int points = getPoints();
        return $"ChecklistGoal:{name},{description},{points},{_target},{_bonus},{_amountCompleted}";
    }
}
