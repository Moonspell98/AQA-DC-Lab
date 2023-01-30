using Homework16.HttpClients;
using Homework16.Models;
using Homework16.Models.JsonModels.RequestModels;
using Homework16.Models.JsonModels.ResponseModels;

namespace Homework16.Services
{
    public class ReqresService
    {
        private const string BaseUrl = "https://reqres.in";

        public static RestResponse<ListUsers> GetListOfUsers(int pageId) =>
            BasicHttpClient.PerformGetRequest<ListUsers>($"{BaseUrl}/api/users?page={pageId}", null);

        public static RestResponse<SingleUser> GetSingleUser(int userId) =>
            BasicHttpClient.PerformGetRequest<SingleUser>($"{BaseUrl}/api/users/{userId}", null);

        public static RestResponse DeleteUser(int userId) =>
            BasicHttpClient.PerformDeleteRequest<ListUsers>($"{BaseUrl}/api/users/{userId}", null);

        public static RestResponse<CreateUserResponse> CreateUser(CreateUserRequest user, out DateTime requestSentAt)
        {
            var restResponse = BasicHttpClient.PerformPostRequest<CreateUserRequest, CreateUserResponse>($"{BaseUrl}/api/users/", user, null);
            requestSentAt = DateTime.Now;

            return restResponse;
        }

        public static RestResponse<CreateUserResponse> UpdateUser(int userId, CreateUserRequest user, out DateTime requestSentAt)
        {
            var restResponse = BasicHttpClient.PerformPutRequest<CreateUserRequest, CreateUserResponse>($"{BaseUrl}/api/users/{userId}", user, null);
            requestSentAt = DateTime.Now;

            return restResponse;
        }

        public static RestResponse<CreateUserResponse> UpdateUserPatch(int userId, CreateUserRequest user, out DateTime requestSentAt)
        {
            var restResponse = BasicHttpClient.PerformPatchRequest<CreateUserRequest, CreateUserResponse>($"{BaseUrl}/api/users/{userId}", user, null);
            requestSentAt = DateTime.Now;

            return restResponse;
        }
    }
}
