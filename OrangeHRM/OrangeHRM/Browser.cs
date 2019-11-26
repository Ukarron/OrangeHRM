using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OrangeHRM;
using System;

namespace OrangeHRMTests
{
    public class Browser
    {
        private static IWebDriver _driver;

        public const string Chrome = "Chrome";
        public const string Firefox = "Firefox";
        public const string InternetExplorer = "InternetExplorer";       

        public static IWebDriver Start()
        {
            var browser = RunConfiguration.Browser;

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
            var url = RunConfiguration.Url;

            Driver.Navigate().GoToUrl(url);
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

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ChromeAttribute : CategoryAttribute
    {
        public ChromeAttribute() : base(Browser.Chrome) { }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class FirefoxAttribute : CategoryAttribute
    {
        public FirefoxAttribute() : base(Browser.Firefox) { }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class InternetExplorerAttribute : CategoryAttribute
    {
        public InternetExplorerAttribute() : base(Browser.InternetExplorer) { }
    }
}
