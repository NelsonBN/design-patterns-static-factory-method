var p1 = Point.FromCartesian(2, 3);
Console.WriteLine(p1);

var p2 = Point.FromPolar(1, Math.PI/2);
Console.WriteLine(p2);




// Product
public class Point
{
    public double X { get; private set; }
    public double Y { get; private set; }

    // Private constructor to prevent direct instantiation
    private Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Static factory method for creating a Point in Cartesian coordinates
    public static Point FromCartesian(double x, double y)
        => new(x, y);

    // Static factory method for creating a Point in Polar coordinates
    public static Point FromPolar(double radius, double angle) {
        // Conversion from Polar to Cartesian coordinates
        var x = radius * Math.Cos(angle);
        var y = radius * Math.Sin(angle);
        return new(x, y);
    }

    public override string ToString()
        => $"Point( x = {X}, y = {Y} )";
}
