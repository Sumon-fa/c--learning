public class Point : IComparable<Point>
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;


    }

    public double DistanceToOrigin()
    {


        return Math.Sqrt(X * X + Y * Y);
    }
    public int CompareTo(Point anotherPoint)
    {
        var distance = DistanceToOrigin();
        var anotherDistance = anotherPoint.DistanceToOrigin();
        return distance.CompareTo(anotherDistance);
    }
}