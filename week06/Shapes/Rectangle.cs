public class Rectangle : Shape
{
    // attributes
    private double _length;
    private double _width;

    // constructor
    public Rectangle(string color, double length, double width ) : base(color)
    {
        _length = length;
        _width = width;
    }

    // override method
    public override double GetArea()
    {
        return _length * _width;
    }
}