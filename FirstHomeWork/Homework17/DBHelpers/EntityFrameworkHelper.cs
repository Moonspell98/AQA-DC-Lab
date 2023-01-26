using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using Homework17.Data;
using Homework17EntityFramework;

namespace Homework17.DBHelpers
{
    public class EntityFrameworkHelper
    {
        public static string GetClientExtendedConnectionString(string sqlConnectionString)
        {
            var entityBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = sqlConnectionString,
                Metadata = "res://*/AdonetDb.csdl|res://*/AdonetDb.ssdl|res://*/AdonetDb.msl"
            };

            return entityBuilder.ToString();
        }

        public static List<T> GetAdonetDbInstance<T>(Func<AdonetDbEntities, IQueryable<T>> func)
        {
            using (var context = GetAdonetDbEntities())
            {
                var result = func(context);

                return result.ToList();
            }
        }

        public static List<User> GetUserById(int userId)
        {
            var users = GetAdonetDbInstance<User>(context => context.Users.Where(x => x.Id == userId));

            return users;
        }

        public static User GetLastCreatedUser()
        {
            var users = GetAdonetDbInstance<User>(context => context.Users.OrderByDescending(x => x.Id));
            var lastCreatedUser = users.First();

            return lastCreatedUser;
        }

        public static void CreateUser(User newUser)
        {
            using (var context = GetAdonetDbEntities())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }

        public static AdonetDbEntities GetAdonetDbEntities() =>
            new AdonetDbEntities(GetClientExtendedConnectionString(Configurator.LocalAdnonetDbConnectionString));
    }
}
