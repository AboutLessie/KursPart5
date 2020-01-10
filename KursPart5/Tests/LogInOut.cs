using KursPart5.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPart5.Tests
{
    public class LogInOut
    {
        private readonly IMainPage _mainPage;

        public LogInOut()
        {
        }

        public LogInOut(IMainPage mainPage)
        {
            _mainPage = mainPage;
        }

        public void LogInTest(IWebDriver driver)
        {
            string url = "https://jira.wmi.amu.edu.pl/secure/Dashboard.jspa";
            driver.Navigate().GoToUrl(url);

            _mainPage.FindLogInTextBox(driver).Click();
        }
    }
}
