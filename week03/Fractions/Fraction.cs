public class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    // Constructor with no parameters (initializes to 1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (initializes to top/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor with two parameters (initializes to top/bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number (numerator)
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number (numerator)
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for the bottom number (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number (denominator)
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

   
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}