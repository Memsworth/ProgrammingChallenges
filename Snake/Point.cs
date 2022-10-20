namespace Snake;

public class Point
{
    public int Row { get; private set; }
    public int Col { get; private set; }

    public Point(int row, int col)
    {
        Row = row;
        Col = col;
    }
}