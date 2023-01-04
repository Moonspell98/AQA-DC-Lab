using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class SystemUsersPage : OrangeHRMBasePage
    {
        private MyWebElement _addUserButton => new MyWebElement(By.XPath("//button[contains(normalize-space(), 'Add')]"));

        public string GetCellDataByRow(int rowNumber, string columnName)
        {
            MyWebElement GridCell = new MyWebElement(By.XPath($"//*[@class='oxd-table-card'][{rowNumber}]//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]"));

            return GridCell.Text;
        }

        public void AddUser() => _addUserButton.Click();
    }
}
