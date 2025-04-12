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