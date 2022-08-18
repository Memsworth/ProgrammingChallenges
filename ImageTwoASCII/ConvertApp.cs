using System.Drawing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageTwoASCII;

public class ConvertApp
{
    private static readonly List<ICommand> Commands = new List<ICommand>
    {
        new ConvertCommand(),
        new ExitCommand()
    };
    
    public static void RunProgram()
    {
        while (true)
        {
            Console.WriteLine("Enter command 1.convert (path)  or 2.exit");
            string? userInput = Console.ReadLine();
            foreach (var commands in Commands.Where(commands => commands.Execute(userInput!)))
            {
                Console.WriteLine("Operation Done\n");
            }
        }
    }
}