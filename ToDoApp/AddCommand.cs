using System.Text.RegularExpressions;

namespace ToDoApp;

public class AddCommand : ICommand
{
    public async Task<bool> Execute( Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync, string input, List<TaskItem> table)
    {
        var addMatch = Regex.Match(input!, "add (.*)");
        if (!addMatch.Success || addMatch.Length < 2) return false;
        var taskItem = new TaskItem()
        {
            Name = addMatch.Groups[1].Value
        };
        
        table.Add(taskItem);

        await repoAsync.Add(taskItem);
        return true;
    }
}