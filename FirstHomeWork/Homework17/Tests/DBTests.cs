using System;
using Homework17.Data;
using Homework17.DBHelpers;
using Homework17.ModelsAdonet;
using NUnit.Framework;

namespace Homework17.Tests
{
    public class DBTests
    {
        [Test]
        public void CreateUserTestAdonet()
        {
            var user = new User(RandomHelper.GetRandomString(10), RandomHelper.GetRandomInt(100).ToString());
            AdonetHelper.AddUser(user);

            var createdUser = AdonetHelper.GetLastCreatedUser();
            AdonetHelper.CreateUsersTable("TEST");
            Assert.AreEqual(user.Name, createdUser.Name);
            Assert.AreEqual(user.Age, createdUser.Age);
            Console.WriteLine(createdUser.Name);
        }
    }
}
