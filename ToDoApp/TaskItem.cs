

using Mkb.DapperRepo.Attributes;

namespace ToDoApp;

[SqlTableName("TaskItems")]
public class TaskItem
{
    [PrimaryKey]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public bool Done { get; set; }
    public DateTime CreateTime { get; }  = DateTime.Now;
    public DateTime? TaskDoneTime { get; set; }
    
}