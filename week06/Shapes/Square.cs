public class Square : Shape
{
    // attributes
    private double _side;

    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // override method
    public override double GetArea()
    {
        return _side * _side;
    }
}