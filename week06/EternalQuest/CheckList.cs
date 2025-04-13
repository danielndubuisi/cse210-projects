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
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    // setters
    public void SetAmountCompleted()
    {
        _amountCompleted +=1;
    }

    // methods
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            // increment the amount completed
            SetAmountCompleted();
        }
        else
        {
            IsComplete();
        }       
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()} ";
        }
        else
        {
            return $"[ ] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()} ";           
        }
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{base.GetShortName()},{base.GetDescription()},{base.GetPoints()},{GetBonus()},{GetTarget()},{GetAmountCompleted()}";
    }

}