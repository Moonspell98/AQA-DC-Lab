using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class PimBasePage : OrangeHRMBasePage
    {
        private MyWebElement EmployeeListNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and text()='Employee List']"));
        private MyWebElement AddEmployeeNavigationButton => new MyWebElement(By.XPath("//*[contains(@class, 'nav-tab') and text()='Add Employee']"));

        public void NavigateToEmployeeListPage() => EmployeeListNavigationButton.Click();
        public void NavigateToAddEmployeePage() => AddEmployeeNavigationButton.Click();
    }
}
