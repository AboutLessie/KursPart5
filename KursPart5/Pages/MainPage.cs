using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPart5.Pages
{
    public class MainPage : IMainPage
    {
        private const string logInTextBoxXPath = "//input[@id='login-form-username']";

        public IWebElement FindLogInTextBox(IWebDriver driver)
        {
            return driver.FindElement(By.XPath(logInTextBoxXPath));
        }

    }
}
