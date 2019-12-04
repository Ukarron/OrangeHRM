using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OrangeHRM;

namespace OrangeHRMTests
{
    public class Browser
    {
        private static IWebDriver _driver;
        private static ChromeOptions _chromeOptions;
        private static FirefoxOptions _firefoxOptions;

        public const string Chrome = "Chrome";
        public const string Firefox = "Firefox";
        public const string InternetExplorer = "InternetExplorer";       

        public static IWebDriver Start()
        {
            var browser = RunConfiguration.Browser;

            switch (browser)
            {
                case "Chrome":
                    _driver = new ChromeDriver(ChromeOptions);
                    break;

                case "Firefox":
                    _driver = new FirefoxDriver(FirefoxOptions);
                    break;

                default:
                    _driver = new ChromeDriver(ChromeOptions);
                    break;
            }
            _driver.Manage().Window.Maximize();

            return _driver;
        }

        public void OpenBaseUrl()
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

        public static ChromeOptions ChromeOptions
        {
            get
            {
                _chromeOptions = new ChromeOptions();
                _chromeOptions.AddArgument("--incognito");
                _chromeOptions.AddArgument("--disable-extensions");
                _chromeOptions.AddArgument("--disable-notifications");
                _chromeOptions.AddExcludedArgument("enable-automation");
                _chromeOptions.AddArguments("--disable-popup-blocking");
                _chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                return _chromeOptions;
            }
        }

        public static FirefoxOptions FirefoxOptions
        {
            get
            {
                _firefoxOptions = new FirefoxOptions();
                _firefoxOptions.AddArgument("--disable-infobars");
                _firefoxOptions.AddArgument("--disable-popup-blocking");
                _firefoxOptions.AddArgument("--disable-extensions");
                _firefoxOptions.AddArgument("enable-automation");
                _firefoxOptions.AddAdditionalCapability("useAutomationExtension", false);
                return _firefoxOptions;
            }
        }

        public static void Close()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
