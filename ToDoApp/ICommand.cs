namespace ToDoApp;

public interface ICommand
{
    //Execute command
    Task<bool> Execute( Mkb.DapperRepo.Repo.SqlRepoAsync repoAsync,string input, List<TaskItem> items);
}