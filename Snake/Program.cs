namespace Snake // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var game = new SnakeGame(24);
            game.GameRenderer.RenderGame(game);
        }
    }
}