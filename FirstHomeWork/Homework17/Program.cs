using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using Homework17.DBHelpers;

namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=adonetdb;Trusted_Connection=True;";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    await connection.OpenAsync();
            //    SqlCommand sqlCommand = new SqlCommand();
            //    sqlCommand.CommandText = "CREATE TABLE Users (Id INT PRIMARY KEY IDENTITY, Age INT NOT NULL, NAME NVARCHAR(100) NOT NULL)";
            //    sqlCommand.Connection = connection;
            //    await sqlCommand.ExecuteNonQueryAsync();
            //}
            AdonetHelper.AddEntry("John", 20);
            var user = AdonetHelper.PrintEntryById("1");
            Console.WriteLine(user["NAME"]);
        }
    }
}