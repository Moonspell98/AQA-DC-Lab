using System.Data;
using Homework17.Data;
using Microsoft.Data.SqlClient;

namespace Homework17.DBHelpers
{
    public class AdonetHelper
    {
        public static Dictionary<string, string> PrintEntryById(string id)
        {
            using (var sqlConnection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                var sqlQuerry = $"SELECT * FROM Users WHERE Id = {id}";
                var sqlDataAdapter = new SqlDataAdapter(sqlQuerry, sqlConnection);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                Dictionary<string, string?> user = new Dictionary<string, string?>();

                for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
                {
                    user.Add(dataSet.Tables[0].Columns[i].ColumnName, dataSet.Tables[0].Rows[0].ItemArray[i].ToString());
                }

                foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write($"\t{column.ColumnName}");
                    }

                    Console.WriteLine();

                    foreach (DataRow row in table.Rows)
                    {
                        var cells = row.ItemArray;

                        foreach (var cell in cells)
                        {
                            Console.Write($"\t{cell}");
                        }

                        Console.WriteLine();
                    }
                }

                return user;
            }
        }

        public static void AddEntry(string name, int age)
        {
            using (var sqlConnection = new SqlConnection(Configurator.LocalAdnonetDbConnectionString))
            {
                var sqlQuerry = "SELECT * FROM Users";
                var sqlDataAdapter = new SqlDataAdapter(sqlQuerry, sqlConnection);
                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                var table = dataSet.Tables[0];
                var newRow = table.NewRow();
                newRow["Name"] = name;
                newRow["Age"] = age;
                table.Rows.Add(newRow);
                var commandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(dataSet);
                dataSet.Clear();
                sqlDataAdapter.Fill(dataSet);

                
                
            }
        }
    }
}
