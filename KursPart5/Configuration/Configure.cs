using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace KursPart5.Configuration
{
     public class Configure : IConfigure
     {
        private static IWebDriver driver;

        public static IWebDriver BrowserChoose()
        {
            Console.WriteLine("Select browser:\n");
            Console.WriteLine("IE = 1 | Chrome = 2");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1 || option == 2)
            {
                if (option == 1)
                {
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Close();
                }
                if (option == 2)
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Close();
                }
            }
            else
            {
                Console.WriteLine("Error! We will use Chrome!");
            }
            return driver;
        }


    }
}
