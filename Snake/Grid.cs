namespace Snake;

public class Grid
{
    public int[,] GameGrid { get; private set; }

    public Grid(int dimension)
    {
        GameGrid = new int[dimension, dimension];
    }
}