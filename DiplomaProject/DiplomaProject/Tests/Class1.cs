using DiplomaProject.Common.Drivers;
using DiplomaProject.Data;
using DiplomaProject.PageObjects.OrangeHRM.Elements;
using DiplomaProject.PageObjects.OrangeHRM.Elements.Admin;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.Tests
{
    public class Class1
    {
        IWebDriver _driver;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver = WebDriverFactory.Driver;
        }

        [Test]
        public void Test()
        {
            WebDriverFactory.Driver.Navigate().GoToUrl(TestSettings.OrangeHrmLogInPageUrl);
            var loginPage = new OrangeLoginPage();
            loginPage.LogInAsAdmin();
            var adminPage = new SystemUsersPage();
            adminPage.NavigationItem("Admin").Click();
            adminPage.AddUser();
            var addUserPage = new AddUserPage();
            addUserPage.SelectUserRole("Admin");
            addUserPage.SelectEmployeeName("Rock", "Rock  Python");
            addUserPage.SelectStatus("Enabled");
            Thread.Sleep(1000);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
