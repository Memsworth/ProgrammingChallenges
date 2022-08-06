using System.Text.RegularExpressions;

namespace ToDoApp;

public class AddCommand : ICommand
{
    public bool Execute(string input, List<ToDoItem> table)
    {
        var addMatch = Regex.Match(input!, "add (.*)");
        if (!addMatch.Success) return false;
        table.Add(new ToDoItem(addMatch.Groups[1].Value));
        return true;
    }
}