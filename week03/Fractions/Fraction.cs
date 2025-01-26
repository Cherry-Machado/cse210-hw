using System;
public class Fraction 
{
    private int _top;
    private int _bottom ;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int top1)
    {
        _top = top1;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top1, int bottom1)
    {
        _top = top1;
        _bottom = bottom1;
    }

    // Getter for _top
    public int GetTop()
    {
        return _top;
    }

    // Setter for _top
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for _bottom
    public void SetBottom(int bottom)
    {
        // Validate to ensure denominator is not zero
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}