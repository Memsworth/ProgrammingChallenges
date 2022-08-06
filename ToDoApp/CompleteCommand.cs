using System.Text.RegularExpressions;

namespace ToDoApp;

public class CompleteCommand : ICommand
{
    public bool Execute(string input, List<ToDoItem> table)
    {
        var completeMatch = Regex.Match(input!, "complete (.*)");
        if (!completeMatch.Success) return false;
        var key = completeMatch.Groups[1].Value;
        foreach (var item in table.Where(item => item.Id.Equals(key)))
        {
            item.TaskDoneTime = DateTime.Now;
            item.Done = true;
            break;
        }

        return true;
    }
}