using Mkb.DapperRepo.Repo;
using MySql.Data.MySqlClient;

namespace ToDoApp // Note: actual namespace depends on the project name.
{
    internal static class Program
    {
        private static SqlRepoAsync _sqlRepoAsync = new SqlRepoAsync((()=> new MySqlConnection("Server=localhost;Database=ExampleDb;Uid=root;Pwd=A1234567a;")));
        static async Task Main(string[] args)
        {
            var myTable = new ToDoApplication(_sqlRepoAsync);
           await myTable.RunProgram();
        }
    }

}