using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRMTests
{
    public class Browser
    {
        private static IWebDriver _driver;

        public static IWebDriver Start()
        {
            var browser = ConfigurationManager.AppSettings["Browser"];

            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver();
                    break;

                case "Firefox":
                    _driver = new FirefoxDriver();
                    break;

                default:
                    _driver = new ChromeDriver();
                    break;
            }
            _driver.Manage().Window.Maximize();

            return _driver;
        }

        public void OpenUrl()
        {
            var str = ConfigurationManager.AppSettings["Url"];

            Driver.Navigate().GoToUrl(str);
        }

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = Start();
                }
                return _driver;
            }
        }

        public static void Close()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
