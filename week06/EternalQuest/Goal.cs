// base class holds common behaviors and attributes for all types of goals
public abstract class Goal{
    // attributes
    private string _shortName;
    private string _description;
    private int _points;

    // constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // getters
    public string GetShortName()
    {
        return _shortName;
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected int GetPoints()
    {
        return _points;
    }

    // methods
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[ ] {GetShortName()} ({GetDescription()})";
    }

    public abstract string GetStringRepresentation();

}