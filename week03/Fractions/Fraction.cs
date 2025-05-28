using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public int GetBottom()
    {
        return _bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    
    public void SetBottom(int bottom)
    {
        if (bottom <= 0)
        {
            Console.WriteLine("ERROR - Bottom cannot be less than or equal to zero.");
            Environment.Exit(1); // Exit the program if bottom is zero to prevent division by zero errors.
        }
        _bottom = bottom;
        return;
    }

    public void SetTop(int top)
    {
        _top = top;
        return;
    }
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
}