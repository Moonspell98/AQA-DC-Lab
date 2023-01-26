using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Homework17.Data;
using Homework17.Data.Constants;
using Homework17.ModelsAdonet;
using Microsoft.Data.SqlClient;

namespace Homework17.DBHelpers
{
    public class AdonetHelper
    {
        public static async Task CreateUsersTable(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                await connection.OpenAsync();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = $"CREATE TABLE {tableName} (Id INT PRIMARY KEY IDENTITY, Age INT NOT NULL, Name NVARCHAR(100) NOT NULL)";
                sqlCommand.Connection = connection;
                await sqlCommand.ExecuteNonQueryAsync();
            }
        }
        public static User GetUserById(string id)
        {
            using (var sqlConnection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                var user = new User();
                var sqlQuerry = $"SELECT * FROM Users WHERE Id = {id}";
                var sqlDataAdapter = new SqlDataAdapter(sqlQuerry, sqlConnection);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                Dictionary<string, string> entry = new Dictionary<string, string?>();

                for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
                {
                    entry.Add(dataSet.Tables[0].Columns[i].ColumnName, dataSet.Tables[0].Rows[0].ItemArray[i].ToString());
                }

                user.Name = entry[UserTableColumnNames.Name];
                user.Age = entry[UserTableColumnNames.Age];
                user.Id = int.Parse(entry[UserTableColumnNames.Id]);
                
                return user;
            }
        }

        public static User GetLastCreatedUser()
        {
            using (var sqlConnection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                var user = new User();
                var sqlQuerry = $"SELECT TOP 1 * FROM Users ORDER BY id DESC";
                var sqlDataAdapter = new SqlDataAdapter(sqlQuerry, sqlConnection);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                Dictionary<string, string?> entry = new Dictionary<string, string?>();

                for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
                {
                    entry.Add(dataSet.Tables[0].Columns[i].ColumnName, dataSet.Tables[0].Rows[0].ItemArray[i].ToString());
                }

                user.Name = entry[UserTableColumnNames.Name];
                user.Age = entry[UserTableColumnNames.Age];
                user.Id = int.Parse(entry[UserTableColumnNames.Id]);

                return user;
            }
        }

        public static void AddUser(User user)
        {
            using (var sqlConnection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                var sqlQuerry = "SELECT * FROM Users";
                var sqlDataAdapter = new SqlDataAdapter(sqlQuerry, sqlConnection);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                var table = dataSet.Tables[0];
                var newRow = table.NewRow();
                newRow[UserTableColumnNames.Name] = user.Name;
                newRow[UserTableColumnNames.Age] = user.Age;
                table.Rows.Add(newRow);
                var commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(dataSet);

                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet);
            }
        }
    }
}
