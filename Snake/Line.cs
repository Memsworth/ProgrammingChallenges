namespace Snake;

public class Line
{
    public Location Start { get; private set; }
    public Location End { get; private set; }

    public Line(Location start, Location end)
    {
        Start = start;
        End = end;
    }
}