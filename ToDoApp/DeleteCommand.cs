using System.Text.RegularExpressions;

namespace ToDoApp;

public class DeleteCommand : ICommand
{
    public async Task<bool> Execute(Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync, string input, List<TaskItem> table)
    {
        var deleteMatch = Regex.Match(input, "delete (.*)");
        if (!deleteMatch.Success) return false;
        var key = deleteMatch.Groups[1].Value;
        for (int i = 0; i < table.Count; i++)
        {
            var item = table[i];
            if (item.Id.Equals(key))
            {
                table.Remove(item);
                await repoAsync.Delete(item);
                return true;
            }
        }

        Console.WriteLine($"{new ArgumentException("Item not found")}");
        return true;
    }
}