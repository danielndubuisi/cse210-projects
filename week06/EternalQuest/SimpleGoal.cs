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

    // setter
    public void SetIsComplete()
    {
        _isComplete = true;
    }

    // methods
    public override void RecordEvent()
    {
        SetIsComplete();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{IsComplete()}";
    }

}