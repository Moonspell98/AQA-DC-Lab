using DiplomaProject.Common.WebElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
