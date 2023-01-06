using DiplomaProject.Data.Enums;
using Microsoft.Extensions.Configuration;

namespace DiplomaProject.Data
{
    public class TestSettings
    {
        public static Browsers Browser { get; set; }
        public static string OrangeHrmLogInPageUrl { get; set; }
        public static string EmployeeListPageUrl { get; set; }
        public static string AddEmployeePageUrl { get; set; }
        public static string UserManagementPageUrl { get; set; }
        public static string AddUserPageUrl { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }

        public static IConfiguration TestConfiguration { get; } = new ConfigurationBuilder().AddJsonFile("testsettings.json").Build();

        static TestSettings()
        {
            Enum.TryParse(TestConfiguration["Common:Browser"], out Browsers browser);
            Browser = browser;

            OrangeHrmLogInPageUrl = TestConfiguration["Common:OrangeHrmUrls:LogInPage"];
            EmployeeListPageUrl = TestConfiguration["Common:OrangeHrmUrls:EmployeeListPage"];
            AddEmployeePageUrl = TestConfiguration["Common:OrangeHrmUrls:AddEmployeePage"];
            UserManagementPageUrl = TestConfiguration["Common:OrangeHrmUrls:UserManagementPage"];
            AddUserPageUrl = TestConfiguration["Common:OrangeHrmUrls:AddUserPage"];

            UserName = TestConfiguration["TestData:UserName"];
            Password = TestConfiguration["TestData:Password"];
        }
    }
}
