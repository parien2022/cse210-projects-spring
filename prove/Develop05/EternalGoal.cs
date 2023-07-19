public class EternalGoal : Goal {

    public EternalGoal (String name, String description, int points) : base (name, description, points){
    }


    public override void RecordEvent(){
        IsComplete();
    }

    public override bool IsComplete(){
        return false;
    }

    public override string GetStringRepresentation() {
        String name = getName();
        String description = getDescription();
        int points = getPoints();
        return $"EternalGoal:{name},{description},{points}";
    }
}