// this class handles the eternal goals
public class EternalGoal : Goal
{    
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // methods
    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

}