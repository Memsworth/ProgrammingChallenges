using System.Text.RegularExpressions;

namespace ToDoApp;

public class ExitCommand : ICommand
{
    public bool Execute(string input, List<ToDoItem> items)
    {
        var exitMatch = Regex.Match(input!, "exit");
        if (!exitMatch.Success) return false;
        Console.WriteLine("Thank you for using the ToDo App");
        Environment.Exit(0);
        return true;
    }
}