using DiplomaProject.PageObjects.OrangeHRM.Elements;
using DiplomaProject.PageObjects.OrangeHRM.Elements.Admin;
using DiplomaProject.PageObjects.OrangeHRM.Elements.PIM;
using DiplomaProject.PageObjects.OrangeHRMModals;

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
        public static DeleteEmployeeModal DeleteEmployeeModal => GetPage<DeleteEmployeeModal>();

        private static T GetPage<T>() where T : new() => new T();
    }
}
