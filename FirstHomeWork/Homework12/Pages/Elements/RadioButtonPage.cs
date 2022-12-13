using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class RadioButtonPage : BasePage
    {
        private static string _yesRadioBoxLocator = "//*[@id = 'yesRadio']";
        private static string _impressiveRadioBoxLocator = "//*[@id = 'impressiveRadio']";
        private static string _noRadioBoxLocator = "//*[@id = 'noRadio']";

        private MyWebElement _yesRadioBox = new MyWebElement(By.XPath(_yesRadioBoxLocator));
        private MyWebElement _impressiveRadioBox = new MyWebElement(By.XPath(_impressiveRadioBoxLocator));
        private MyWebElement _noRadioBox = new MyWebElement(By.XPath(_noRadioBoxLocator));
        private MyWebElement _yesRadioButton = new MyWebElement(By.XPath($"{_yesRadioBoxLocator}/following-sibling::label"));
        private MyWebElement _impressiveRadioButton = new MyWebElement(By.XPath($"{_impressiveRadioBoxLocator}/following-sibling::label"));
        private MyWebElement _noRadioButton = new MyWebElement(By.XPath($"{_noRadioBoxLocator}/following-sibling::label"));
        private MyWebElement _resultTextSection = new MyWebElement(By.XPath("//*[@class='text-success']"));

        public string GetYesCheckedProperty() => _yesRadioBox.GetDomProperty("checked");

        public string GetNoCheckedProperty() => _noRadioBox.GetDomProperty("checked");

        public string GetImpressiveCheckedProperty() => _impressiveRadioBox.GetDomProperty("checked");

        public void SelectYes() => _yesRadioButton.Click();

        public void SelectNo() => _noRadioButton.Click();

        public void SelectImpressive() => _impressiveRadioButton.Click();

        public string GetResultText() => _resultTextSection.Text;

    }
}
