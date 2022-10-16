namespace Snake;

public class Snake
{
    public List<Line> SnakePosition { get; private set; }

    public Snake(Line spawnPoint)
    {
        SnakePosition = new List<Line>();
        SnakePosition.Add(spawnPoint);
    }
}