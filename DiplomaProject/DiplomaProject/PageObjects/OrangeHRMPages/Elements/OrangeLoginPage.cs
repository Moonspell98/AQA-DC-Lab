using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements
{
    public class OrangeLoginPage
    {
        private MyWebElement UserNameTexBox => new MyWebElement(By.XPath("//input[@name='username']"));
        private MyWebElement PasswordTextBox => new MyWebElement(By.XPath("//input[@name='password']"));
        private MyWebElement LoginButton => new MyWebElement(By.XPath("//button[contains(@class, 'login-button')]"));
        private MyWebElement WarningTextSection => new MyWebElement(By.XPath("//*[contains(@class, 'content--error')]/*[contains(@class, 'content-text')]"));

        public void EnterUserName(string userName) => UserNameTexBox.SendKeys(userName);

        public void EnterPassword(string password) => PasswordTextBox.SendKeys(password);

        public string GetWarningSectionText() => WarningTextSection.Text;

        public void PressOnLoginButton() => LoginButton.Click();

        public void LogInAsAdmin()
        {
            EnterUserName(TestSettings.UserName);
            EnterPassword(TestSettings.Password);
            PressOnLoginButton();
        }
    }
}
