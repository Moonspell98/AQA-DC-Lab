using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements
{
    public class OrangeLoginPage
    {
        private MyWebElement _userNameTexBox => new MyWebElement(By.XPath("//input[@name='username']"));
        private MyWebElement _passwordTextBox => new MyWebElement(By.XPath("//input[@name='password']"));
        private MyWebElement _loginButton => new MyWebElement(By.XPath("//button[contains(@class, 'login-button')]"));
        private MyWebElement _warningTextSection => new MyWebElement(By.XPath("//*[contains(@class, 'content--error')]/*[contains(@class, 'content-text')]"));

        public void EnterUserName(string userName) => _userNameTexBox.SendKeys(userName);

        public void EnterPassword(string password) => _passwordTextBox.SendKeys(password);

        public string GetWarningSectionText() => _warningTextSection.Text;

        public void PressOnLoginButton() => _loginButton.Click();

        public void LogInAsAdmin()
        {
            EnterUserName(TestSettings.UserName);
            EnterPassword(TestSettings.Password);
            PressOnLoginButton();
        }
    }
}
