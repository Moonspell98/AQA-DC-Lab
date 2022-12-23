using Homework12.Common.WebElements;
using Homework12.PageObjects;
using OpenQA.Selenium;

namespace Homework12.Pages.Elements
{
    public class RadioButtonPage : BasePage
    {
        private MyRadioButton _yesRadioButton = new MyRadioButton(By.XPath("//*[@id = 'yesRadio']"));
        private MyRadioButton _impressiveRadioButton = new MyRadioButton(By.XPath("//*[@id = 'impressiveRadio']"));
        private MyRadioButton _noRadioButton = new MyRadioButton(By.XPath("//*[@id = 'noRadio']"));
        private MyWebElement _resultTextSection = new MyWebElement(By.XPath("//*[@class='text-success']"));

        public bool IsYesRadioChecked() => _yesRadioButton.IsChecked;

        public bool IsNoRadioChecked() => _noRadioButton.IsChecked;

        public bool IsImpressiveRadioChecked() => _impressiveRadioButton.IsChecked;

        public void SelectYes() => _yesRadioButton.Check();

        public void SelectNo() => _noRadioButton.Check();

        public void SelectImpressive() => _impressiveRadioButton.Check();

        public string GetResultText() => _resultTextSection.Text;
    }
}
