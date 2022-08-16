using System.Text.RegularExpressions;

namespace ImageTwoASCII;

public class LoadCommand : ICommand
{
    public bool Execute(string input)
    {
        var loadMatch = Regex.Match(input!, "loadfile (.*)");
        if (!loadMatch.Success) return false;
        var filePath = loadMatch.Groups[1].Value;
        if (File.Exists(filePath)) return true;
        Console.WriteLine($"{new ArgumentException("File doesn't exist")}");
        return false;
    }
}