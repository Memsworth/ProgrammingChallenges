namespace Snake;

public class GameRenderer
{
    
    public void RenderGame(SnakeGame game)
    {
        Console.WriteLine();
        for (int i = 0; i < game.GameGrid.GameGrid.GetLength(0); i++)
        {
            for (int j = 0; j < game.GameGrid.GameGrid.GetLength(1); j++)
            {
                if (game.Apple.AppleLocation.Row == i && game.Apple.AppleLocation.Col == j)
                {
                    Console.Write($"A", Console.ForegroundColor == ConsoleColor.Red);
                }
                else
                {
                    foreach (var point in game.Snake.SnakePosition)
                    {
                        if (point.Row == i && point.Col == j)
                        {
                            Console.Write("S");
                        }
                    }
                }

            }

            Console.WriteLine();
        }
    }
}