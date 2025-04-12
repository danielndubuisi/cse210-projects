// base class holds common behaviors and attributes for all types of goals
public class Goal{
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

    // methods
    public virtual void RecordEvent()
    {
        
    }
    public virtual bool isComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

}