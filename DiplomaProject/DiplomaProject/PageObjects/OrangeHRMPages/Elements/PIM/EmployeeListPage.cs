using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using DiplomaProject.Data.Constants;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.PIM
{
    public class EmployeeListPage : PimBasePage
    {
        private MyWebElement AddEmployeeButton => new MyWebElement(By.XPath("//button[text()[normalize-space()='Add']]"));
        private MyWebElement FilterByEmployeeIdTextBox => new MyWebElement(By.XPath($"//*[text()='Employee Id']/ancestor::div/following-sibling::div/input"));
        private MyWebElement SearchButton => new MyWebElement(By.XPath("//button[@type='submit']"));
        public MyGrid EmployeesGrid => new MyGrid(By.XPath("//*[contains(@class, 'employee-list')]"));

        public EmployeeListPage()
        {
            pageUrl = TestSettings.EmployeeListPageUrl;
        }

        public AddEmployeePage ClickOnAddEmployeeButton()
        {
            AddEmployeeButton.Click();
            return GenericPages.AddEmployeePage;
        }

        public void SearchById(string id)
        {
            FilterByEmployeeIdTextBox.SendKeys(id);
            SearchButton.Click();
        }
    }
}
