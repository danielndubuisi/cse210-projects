// running activity
public class Running : Activity
{
    // other attributes
    private double _distance;

    // constructor
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    // methods
    public override double GetDistance(){
        return _distance;
    }

    public override double GetSpeed(){
        // round value to 2 decimal
        return Math.Round(GetDistance() / base.GetDuration() * 60, 2);
    }

    public override double GetPace(){
        // round value to 2 decimal
        return Math.Round(base.GetDuration() / GetDistance(), 2);
    }

    public override string GetActivityName(){
        return "Running";
    }
}