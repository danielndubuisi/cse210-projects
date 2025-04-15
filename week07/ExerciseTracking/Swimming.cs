// running activity
public class Swimming : Activity
{
    // other attributes
    private int _numberOfLaps;

    // constructor
    public Swimming(DateTime date, int duration, int numberOfLaps) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    // getter
    private int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }

    // methods
    public override double GetDistance()
    {
        // round value to 2 decimal
        double distance = GetNumberOfLaps() * 50 / 1000;
        return Math.Round(distance, 2);
    }

    public override double GetSpeed()
    {
        // round value to 2 decimal
        double speed = GetDistance() / base.GetDuration() * 60;
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        // round value to 2 decimal
        double pace = base.GetDuration() / GetDistance();
        return Math.Round(pace, 2);
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}