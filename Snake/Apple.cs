namespace Snake;

public class Apple
{
    public Location AppleLocation { get; private set; }

    public Apple(Location location)
    {
        AppleLocation = location;
    }
}