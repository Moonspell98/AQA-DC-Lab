using DiplomaProject.PageObjects.OrangeHRM.Elements;
using DiplomaProject.PageObjects.OrangeHRM.Elements.Admin;
using DiplomaProject.PageObjects.OrangeHRM.Elements.PIM;

namespace DiplomaProject.PageObjects.OrangeHRM
{
    public class GenericPages
    {
        public static OrangeLoginPage OrangeLoginPage => GetPage<OrangeLoginPage>();
        public static EmployeeListPage EmployeeListPage => GetPage<EmployeeListPage>();
        public static AddEmployeePage AddEmployeePage => GetPage<AddEmployeePage>();
        public static SystemUsersPage SystemUsersPage => GetPage<SystemUsersPage>();
        public static AddUserPage AddUserPage => GetPage<AddUserPage>();
        public static PersonalDetailsPage PersonalDetailsPage  => GetPage<PersonalDetailsPage>();


        private static T GetPage<T>() where T : new() => new T();
    }
}
