using Homework16.Services;
using System.Net;
using Homework16.Helpers;
using Homework16.Models.JsonModels.RequestModels;
using Homework16.Models.JsonModels.ResponseModels;
using NUnit.Framework;

namespace Homework16
{
    public class Tests
    {
        [Test]
        public void GetUserByNotExistingId()
        {
            // Generate not existing user id
            var existingUsersIds = GetAllUsersIds();
            var notExistingUserId = RandomHelper.GetRandomIntExcludingList(100, existingUsersIds);
            // Getting not existing user
            var notExistingSingleUser = ReqresService.GetSingleUser(notExistingUserId);

            Assert.AreEqual(HttpStatusCode.NotFound, notExistingSingleUser.StatusCode);
        }

        [Test]
        public void CreateUserAndCompareData()
        {
            var name = RandomHelper.GetRandomString(5);
            var job = RandomHelper.GetRandomString(5);
            DateTime requestSentAt;
            var user = new CreateUserRequest()
            {
                Name = name,
                Job = job
            };

            var createUser = ReqresService.CreateUser(user, out requestSentAt);
            Assert.AreEqual(name, createUser.ResponseModel.Name); 
            Assert.AreEqual(job, createUser.ResponseModel.Job);
            Assert.AreEqual(requestSentAt.ToLocalTime().Date, createUser.ResponseModel.CreatedAt.ToLocalTime().Date);
        }

        [Test]
        public void UpdateExistingUser()
        {
            var existingUsersIds = GetAllUsersIds();
            var existingUserId = RandomHelper.GetRandomIntFromList(existingUsersIds);
            var name = RandomHelper.GetRandomString(5);
            var job = RandomHelper.GetRandomString(5);
            DateTime requestSentAt;
            var user = new CreateUserRequest()
            {
                Name = name,
                Job = job
            };

            var updatedUser = ReqresService.UpdateUser(existingUserId, user, out requestSentAt);

            Assert.AreEqual(HttpStatusCode.OK, updatedUser.StatusCode);
            Assert.AreEqual(name, updatedUser.ResponseModel.Name);
            Assert.AreEqual(job, updatedUser.ResponseModel.Job);
        }

        [Test]
        public void UpdateNotExistingUser()
        {
            var existingUsersIds = GetAllUsersIds();
            var notExistingUserId = RandomHelper.GetRandomIntExcludingList(1000, existingUsersIds);
            var name = RandomHelper.GetRandomString(5);
            var job = RandomHelper.GetRandomString(5);
            DateTime requestSentAt;
            var user = new CreateUserRequest()
            {
                Name = name,
                Job = job
            };
            Console.WriteLine(notExistingUserId);

            var updatedUser = ReqresService.UpdateUser(notExistingUserId, user, out requestSentAt);

            Assert.AreEqual(HttpStatusCode.NotFound, updatedUser.StatusCode);
        }

        [Test]
        public void UpdateExistingUserPatch()
        {
            var existingUsersIds = GetAllUsersIds();
            var existingUserId = RandomHelper.GetRandomIntFromList(existingUsersIds);
            var name = RandomHelper.GetRandomString(5);
            var job = RandomHelper.GetRandomString(5);
            DateTime requestSentAt;
            var user = new CreateUserRequest()
            {
                Name = name,
                Job = job
            };

            var updatedUser = ReqresService.UpdateUserPatch(existingUserId, user, out requestSentAt);

            Assert.AreEqual(HttpStatusCode.OK, updatedUser.StatusCode);
            Assert.AreEqual(name, updatedUser.ResponseModel.Name);
            Assert.AreEqual(job, updatedUser.ResponseModel.Job);
        }

        [Test]
        public void DeleteExistingUser()
        {
            var existingUsersIds = GetAllUsersIds();
            var existingUserId = RandomHelper.GetRandomIntFromList(existingUsersIds);
            var deleteUser = ReqresService.DeleteUser(existingUserId);

            Assert.AreEqual(HttpStatusCode.NoContent, deleteUser.StatusCode);
        }

        [Test]
        public void DeleteNotExistingUser()
        {
            var existingUsersIds = GetAllUsersIds();
            var notExistingUserId = RandomHelper.GetRandomIntExcludingList(1000, existingUsersIds);
            var deleteUser = ReqresService.DeleteUser(notExistingUserId);

            Assert.AreEqual(HttpStatusCode.NotFound, deleteUser.StatusCode);
        }

        [Test]
        public void GetUserFromUserList()
        {
            var existingUsers = GetAllUsers();
            var randomUser = existingUsers[RandomHelper.GetRandomInt(0, existingUsers.Count)];
            var singleUser = ReqresService.GetSingleUser(randomUser.Id);

            Assert.AreEqual(HttpStatusCode.OK, singleUser.StatusCode);
            Assert.AreEqual(randomUser.Email, singleUser.ResponseModel.Data.Email);
            Assert.AreEqual(randomUser.Id, singleUser.ResponseModel.Data.Id);
            Assert.AreEqual(randomUser.First_name, singleUser.ResponseModel.Data.First_name);
            Assert.AreEqual(randomUser.Last_name, singleUser.ResponseModel.Data.Last_name);
        }

        public List<SingleUserData> GetAllUsers()
        {
            var firstListOfUsers = ReqresService.GetListOfUsers(1);
            var totalPages = firstListOfUsers.ResponseModel.Total_pages;
            List<SingleUserData> existingUsers = firstListOfUsers.ResponseModel.Data.ToList();
            // Selecting all existing users
            for (int i = 1; i <= totalPages; i++)
            {
                var nextListOfUsers = ReqresService.GetListOfUsers(i);
                existingUsers = existingUsers.Union(nextListOfUsers.ResponseModel.Data).ToList();
            }

            return existingUsers;
        }

        public List<int> GetAllUsersIds()
        {
            var allUsers = GetAllUsers();
            var existingUsersIds = allUsers.Select(user => user.Id).ToList();

            return existingUsersIds;
        }
    }
}