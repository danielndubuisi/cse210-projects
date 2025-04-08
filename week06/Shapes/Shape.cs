public class Shape{
    // attrubutes
    private string _color;

    // constructor
    public Shape(string color)
    {
        _color = color;
    }

    // getter
    public string GetColor()
    {
        return _color;
    }

    // setter
    public void SetColor(string color)
    {
        _color = color;
    }

    // methods
    public virtual double GetArea()
    {
        return 0;
    }
}