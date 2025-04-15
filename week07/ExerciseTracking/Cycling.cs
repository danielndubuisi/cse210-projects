// running activity
public class Cycling : Activity
{
    // other attributes
    private double _speed;

    // constructor
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    // methods
    public override double GetDistance()
    {
        // round value to 2 decimal
        return Math.Round(_speed * base.GetDuration() / 60, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // round value to 2 decimal
        return Math.Round(base.GetDuration() / GetDistance(), 2);
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }
}