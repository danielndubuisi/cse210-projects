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

    // getters
    protected int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    protected int GetTarget()
    {
        return _target;
    }

    protected int GetBonus()
    {
        return _bonus;
    }

    // methods
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        bool completed = (GetAmountCompleted() == GetTarget()) ? true : false;
        return completed;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()} ";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{GetBonus()},{GetTarget()},{GetAmountCompleted()}";
    }

}