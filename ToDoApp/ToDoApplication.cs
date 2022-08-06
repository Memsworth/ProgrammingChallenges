/*
 *  This is a to do application in CLI where the user has to can add their tasks view them
 *  This application uses a Nuget package called PrettyConsole Helper by ChrisK
 *  In addition, this was built on stream with the help of Kevin (https://github.com/kevingosse)
 *  For more of these challenges, they are planned to be published in a day by day basis.
 */


namespace ToDoApp;
public class ToDoApplication
{
    public List<ToDoItem> Table { get; set; }

    public List<ICommand> Commands = new List<ICommand>
    {
        new AddCommand(),
        new CompleteCommand(),
        new DeleteCommand(),
        new PrintCommand(),
        new ExitCommand()
    };
    
    public ToDoApplication()
    {
        Table = new List<ToDoItem>();
    }
    public void RunProgram()
    {
        while (true)
        {
            PrintMenu();
            Console.Write("What you wanna do?: ");
            string? userInput = Console.ReadLine();
            foreach (var commands in Commands.Where(commands => commands.Execute(userInput!, Table)))
            {
                Console.WriteLine("Operation Done\n");
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