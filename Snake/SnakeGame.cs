namespace Snake;

public class SnakeGame
{
    public Grid GameGrid { get; }
    public Apple Apple { get; }
    public Snake Snake { get; }
    public System.Timers.Timer GameTimer { get; private set; }
    public GameRenderer GameRenderer { get; }
    public Random _randomGenerator = new Random();
    
    public SnakeGame(int dimension)
    {
        GameGrid = new Grid(dimension);
        Apple = new Apple(
            new Location(_randomGenerator.Next(0, dimension - 1), _randomGenerator.Next(0, dimension - 1)));
        GameTimer = new System.Timers.Timer();

        var spawnPoint = new Line(new Location(dimension / 2, dimension / 2),
            new Location(dimension / 2 + 1, dimension / 2 + 1));
        Snake = new Snake(spawnPoint);
        GameRenderer = new GameRenderer();
    }
    
    
}