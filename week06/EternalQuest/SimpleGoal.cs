// this class handles the simple goals
public class SimpleGoal : Goal
{
    //other attributes
    private bool _isComplete;

    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // set default value to false
        _isComplete = false;
    }

    // getter
    protected bool GetIsComplete()
    {
        return _isComplete;
    }

    // methods
    public override void RecordEvent()
    {
        Console.WriteLine();
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{GetIsComplete()}";
    }

}