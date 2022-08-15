using System.Text.RegularExpressions;

namespace ImageTwoASCII;

public class ExitCommand : ICommand
{
    public bool Execute(string input)
    {
        var exitMatch = Regex.Match(input, "exit");
        if (!exitMatch.Success) return false;
        Console.WriteLine("Thank you for converting your images");
        Environment.Exit(0);
        return true;
    }
}