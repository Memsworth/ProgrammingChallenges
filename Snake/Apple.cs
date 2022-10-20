namespace Snake;

public class Apple
{
    public Point AppleLocation { get; private set; }

    public Apple(Point location)
    {
        AppleLocation = location;
    }
}