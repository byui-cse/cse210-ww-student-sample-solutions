public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _side * _side;
    }
}