namespace Snake;

public class GameRenderer
{
    
    public void RenderGame(SnakeGame game)
    {
        for (int i = 0; i < game.GameGrid.GameGrid.GetLength(0); i++)
        {
            for (int j = 0; j < game.GameGrid.GameGrid.GetLength(1); j++)
            {
                foreach (var line in game.Snake.SnakePosition)
                {
                    if (line.Start.Row == i && line.Start.Col == j)
                    {
                        Console.Write("S");
                    }

                    if (line.End.Row == i && line.End.Col == j)
                    {
                        Console.Write("S");
                    }
                    
                    if (game.Apple.AppleLocation.Row == i && game.Apple.AppleLocation.Col == j)
                    {
                        Console.Write("A");
                    }
                    
                    else
                    {
                        Console.Write("-");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}