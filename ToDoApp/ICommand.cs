namespace ToDoApp;

public interface ICommand
{
    //Execute command
    bool Execute(string input, List<ToDoItem> items);
}