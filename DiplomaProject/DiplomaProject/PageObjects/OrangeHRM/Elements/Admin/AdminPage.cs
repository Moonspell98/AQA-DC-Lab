using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements.Admin
{
    public class AdminPage : OrangeHRMBasePage
    {
        private DisplayedWebElement _addUserButton => new DisplayedWebElement(By.XPath("//button[contains(normalize-space(), 'Add')]"));

        public string GetCellDataByRow(int rowNumber, string columnName)
        {
            ExistingWebElement GridCell = new ExistingWebElement(By.XPath($"//*[@class='oxd-table-card'][{rowNumber}]//div[@class='oxd-table-cell oxd-padding-cell'][count(//*[@role='columnheader'][text()='{columnName}']//preceding-sibling::div) + 1]"));

            return GridCell.Text;
        }
    }
}
