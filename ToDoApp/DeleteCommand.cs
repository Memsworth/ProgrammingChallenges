using System.Text.RegularExpressions;

namespace ToDoApp;

public class DeleteCommand : ICommand
{
    public bool Execute(string input, List<ToDoItem> table)
    {
        var deleteMatch = Regex.Match(input, "delete (.*)");
        if (!deleteMatch.Success) return false;
        var key = deleteMatch.Groups[1].Value;
        for (int i = 0; i < table.Count; i++)
        {
            if (!table[i].Id.Equals(key)) continue;
            table.Remove(table[i]);
            return true;
        }
        Console.WriteLine($"{new ArgumentException("Item not found")}");
        return true;

    }
}