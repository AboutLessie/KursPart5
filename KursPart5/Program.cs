using System;
using KursPart5.Configuration;
using KursPart5.Logger;
using KursPart5.Tests;
using OpenQA.Selenium;

namespace KursPart5
{
    public class Program
    {
        private readonly IConfigure _configure;
        private readonly ILogMaker _log;
        private readonly ILogInOut _logInOut;

        public Program(IConfigure configure, ILogMaker log, ILogInOut logInOut)
        {
            _configure = configure;
            _log = log;
            _logInOut = logInOut;
        }

        static void Main()
        {
            try
            {
                IWebDriver driver = Configure.BrowserChoose();

                LogInOut logIn = new LogInOut();
                logIn.LogInTest(driver);

                LogMaker log = new LogMaker();
                log.AddToLog("Udało się!");
            }
            catch (Exception e)
            {
                LogMaker log = new LogMaker();
                log.AddToLog("Error " + e);
            }
            finally
            {
                LogMaker log = new LogMaker();
                log.CloseLog();
            }

        }
    }
}
