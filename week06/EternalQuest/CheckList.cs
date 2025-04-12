// tnis class handles the checklist goals
public class CheckListGoal : Goal
{
    //other attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    // constructor
    public CheckListGoal(string name, string description, int points, int target, int bonusPoints) : base(name, description, points)
    {
        // set a defualt value of zero
        _amountCompleted = 0;
        _target = target;
        _bonus = bonusPoints;
    }


    // methods
    public override void RecordEvent()
    {
        
    }

    public override bool isComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }

}