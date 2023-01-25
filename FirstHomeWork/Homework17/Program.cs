using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using Homework17.DBHelpers;
using Homework17.ModelsAdonet;

namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AdonetHelper.CreateUsersTable("TEST");
        }
    }
}