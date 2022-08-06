/*
 *  This is a to do application in CLI where the user has to can add their tasks view them
 *  This application uses a Nuget package called PrettyConsole Helper by ChrisK
 *  In addition, this was built on stream with the help of Kevin (https://github.com/kevingosse)
 *  For more of these challenges, they are planned to be published in a day by day basis.
 */


using System.Reflection;

namespace ToDoApp;
public class ToDoApplication
{
    private Mkb.DapperRepo.Repo.SqlRepoAsync _repoAsync;
    public List<TaskItem> Table { get; set; }

    public List<ICommand> Commands = Assembly.GetAssembly(typeof(ToDoApplication)).GetTypes()
        .Where(e => e.IsAbstract == false && e.IsClass && e.IsAssignableTo(typeof(ICommand)))
        .Select(e => (ICommand) Activator.CreateInstance(e))
        .ToList();
    
    public ToDoApplication(Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync)
    {
        _repoAsync = repoAsync;
    }
    
    public async Task RunProgram()
    {
        Table = (await _repoAsync.GetAll<TaskItem>()).ToList();
        while (true)
        {
            PrintMenu();
            Console.Write("What you wanna do?: ");
            string? userInput = Console.ReadLine();
            foreach (var command in Commands)
            {
                if (await command.Execute(_repoAsync, userInput!, Table))
                {
                    Console.WriteLine("Operation Done\n");
                    break;
                }
            }
        }
        
    }
    private static void PrintMenu()
    {
        Console.WriteLine("Print Table");
        Console.WriteLine("Add item");
        Console.WriteLine("Complete Task");
        Console.WriteLine("Delete item\n");
    }
}