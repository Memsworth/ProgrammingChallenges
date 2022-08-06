using System.Text.RegularExpressions;
using PrettyConsoleHelper;

namespace ToDoApp;

public class PrintCommand : ICommand
{
    public async Task<bool> Execute(Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync,string input, List<TaskItem> table)
    {
        var printMatch = Regex.Match(input, "^print");

        if (!printMatch.Success) return false;
        if (table.Count == 0)
        {
            Console.WriteLine($"{new ArgumentException("List is empty")}");
        }
        else
        {
            Console.WriteLine();
            var myTable = new PrettyTable().AddRowsWithDefaultHeaders(table);
            myTable.Write();
        }
        return true;
    }
}