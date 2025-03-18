public class Fraction
{
    // attributes
    private int _top;
    private int _bottom;

    // no parameter constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // top number getter
    public int GetTop()
    {
        return _top;
    }
    // top number setter
    public void SetTop(int top)
    {
        _top = top;
    }
    // bottom number getter
    public int GetBottom()
    {
        return _bottom;
    }
    // bottom number getter
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // methods
    public string GetFractionString()
    {
        string top = GetTop().ToString();
        string bottom = GetBottom().ToString();
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        double top = GetTop();
        double bottom = GetBottom();
        double decimalValue = top/bottom;       
        return decimalValue;
    }
}