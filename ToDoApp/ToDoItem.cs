

namespace ToDoApp;

public class ToDoItem
{
    public string Id { get; }
    public string? Task { get; }
    public bool Done { get; set; }
    public DateTime CreateTime { get; }
    public DateTime? TaskDoneTime { get; set; }

    public ToDoItem(string? task)
    {
        Id = Guid.NewGuid().ToString();
        Task = task;
        Done = false;
        CreateTime = DateTime.Now;
        TaskDoneTime = null;
    }
}