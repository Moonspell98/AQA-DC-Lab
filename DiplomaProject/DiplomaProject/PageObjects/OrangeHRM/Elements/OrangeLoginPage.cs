using DiplomaProject.Common.WebElements;
using DiplomaProject.Data;
using OpenQA.Selenium;

namespace DiplomaProject.PageObjects.OrangeHRM.Elements
{
    public class OrangeLoginPage
    {
        private ExistingWebElement _userNameTexBox => new ExistingWebElement(By.XPath("//input[@name='username']"));
        private ExistingWebElement _passwordTextBox => new ExistingWebElement(By.XPath("//input[@name='password']"));
        private ExistingWebElement _loginButton => new ExistingWebElement(By.XPath("//button[contains(@class, 'login-button')]"));

        public void EnterUserName(string userName) => _userNameTexBox.SendKeys(userName);

        public void EnterPassword(string password) => _passwordTextBox.SendKeys(password);

        public void PressOnLoginButton() => _loginButton.Click();

        public void LogIn()
        {
            EnterUserName(TestSettings.UserName);
            EnterPassword(TestSettings.Password);
            PressOnLoginButton();
        }
    }
}
