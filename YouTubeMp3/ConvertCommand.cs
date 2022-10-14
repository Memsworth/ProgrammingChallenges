using System.Text.RegularExpressions;
namespace YouTubeMp3;

public class ConvertCommand : ICommand
{
    public bool Execute(string command)
    {
        var conversionMatch = Regex.Match(command, "convert (.*)");
        if (!conversionMatch.Success) return false;
        
        
        return false;
    }
}