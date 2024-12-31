public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _width;
    }
}