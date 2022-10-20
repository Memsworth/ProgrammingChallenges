namespace Snake;

public class Snake
{
    public List<Point> SnakePosition { get; private set; }
    public Directions SnakeDirection { get; private set; }
    public bool SnakeAlive { get; private set; }
    public Snake(Point spawnPoint)
    {
        SnakePosition = new List<Point> { spawnPoint };
        SnakeDirection = Directions.Right;
        SnakeAlive = true;
    }
}