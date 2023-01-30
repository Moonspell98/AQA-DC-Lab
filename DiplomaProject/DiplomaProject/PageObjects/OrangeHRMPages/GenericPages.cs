using DiplomaProject.PageObjects.OrangeHRM.Elements;
using DiplomaProject.PageObjects.OrangeHRM.Elements.Admin;
using DiplomaProject.PageObjects.OrangeHRM.Elements.PIM;
using DiplomaProject.PageObjects.OrangeHRMModals;
using DiplomaProject.PageObjects.OrangeHRMPages.Elements.Dashboard;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class GenericPages
    {
        public static OrangeLoginPage OrangeLoginPage => GetPage<OrangeLoginPage>();
        public static EmployeeListPage EmployeeListPage => GetPage<EmployeeListPage>();
        public static AddEmployeePage AddEmployeePage => GetPage<AddEmployeePage>();
        public static SystemUsersListPage SystemUsersListPage => GetPage<SystemUsersListPage>();
        public static AddUserPage AddUserPage => GetPage<AddUserPage>();
        public static PersonalDetailsPage PersonalDetailsPage  => GetPage<PersonalDetailsPage>();
        public static DashboardPage DashboardPage => GetPage<DashboardPage>();
        public static DeleteModal DeleteModal => GetPage<DeleteModal>();
        public static OrangeHRMBasePage OrangeHrmBasePage => GetPage<OrangeHRMBasePage>();

        private static T GetPage<T>() where T : new() => new T();
    }
}
