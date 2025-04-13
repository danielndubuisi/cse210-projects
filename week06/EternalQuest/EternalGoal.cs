// this class handles the eternal goals
public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{

    // methods
    public override void RecordEvent()
    {
        IsComplete();
    }

    public override bool IsComplete()
    {
        // these goals are never marked completed
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()}";
    }

}