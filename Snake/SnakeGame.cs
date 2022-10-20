using System.Diagnostics;

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
            new Point(_randomGenerator.Next(0, dimension - 1), _randomGenerator.Next(0, dimension - 1)));
        GameTimer = new System.Timers.Timer();

        var spawnPoint = new Point(dimension / 2, dimension / 2);
        Snake = new Snake(spawnPoint);
        GameRenderer = new GameRenderer();
    }

    public void Run()
    {
        while (Snake.SnakeAlive != true) 
        {
            GameRenderer.RenderGame(this);
            ICommand command = MoveSnake();

        }
    }

    public ICommand MoveSnake()
    {
        if (Snake.SnakeDirection == Directions.Up)
        {
            if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
            {
                return new MoveCommand();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.LeftArrow)
            {
                return new MoveCommand();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
            {
                return new MoveCommand();
            }
        }

        if (Snake.SnakeDirection == Directions.Up)
        {
            
        }

        if (Snake.SnakeDirection == Directions.Up)
        {
            
        }

        if (Snake.SnakeDirection == Directions.Up)
        {
            
        }

    }
    public void GenerateFood()
    {
        
    }
}

public interface ICommand
{
    public bool Execute();
}

public class MoveCommand : ICommand
{
    public bool Execute()
    {
        throw new NotImplementedException();
    }
}