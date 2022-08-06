using System.Text.RegularExpressions;

namespace ToDoApp;

public class CompleteCommand : ICommand
{
    public async Task<bool> Execute(Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync,string input, List<TaskItem> table)
    {
        var completeMatch = Regex.Match(input!, "complete (.*)");
        if (!completeMatch.Success) return false;
        var key = completeMatch.Groups[1].Value;
        foreach (var item in table.Where(item => item.Id.Equals(key)))
        {
            item.TaskDoneTime = DateTime.Now;
            item.Done = true;
           await repoAsync.Update(item);
            break;
        }

        return true;
    }
}