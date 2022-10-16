namespace Snake;

public class Location
{
    public int Row { get; private set; }
    public int Col { get; private set; }

    public Location(int row, int col)
    {
        Row = row;
        Col = col;
    }
}