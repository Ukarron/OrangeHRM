using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace OrangeHRM.Tools
{
    public sealed class Browser
    {
        private IWebDriver _driver;
        private static ChromeOptions _chromeOptions;
        private static FirefoxOptions _firefoxOptions;
        private static InternetExplorerOptions _internetExplorerOptions;

        public IWebDriver Driver
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

        public IWebDriver Start()
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

                case "IE":
                    _driver = new InternetExplorerDriver(InternetExplorerOptions);
                    break;

                default:
                    _driver = new ChromeDriver(ChromeOptions);
                    break;
            }
            _driver.Manage().Window.Maximize();

            return _driver;
        }

        public void Close()
        {
            _driver.Quit();
            _driver = null;
        }

        private ChromeOptions ChromeOptions
        {
            get
            {
                _chromeOptions = new ChromeOptions();

                _chromeOptions.AddArguments("--incognito",
                    "--disable-popup-blocking",
                    "--disable-extensions",
                    "--disable-notifications");

                _chromeOptions.AddExcludedArgument("enable-automation");
                _chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                return _chromeOptions;
            }
        }

        private FirefoxOptions FirefoxOptions
        {
            get
            {
                _firefoxOptions = new FirefoxOptions();

                _firefoxOptions.AddArguments("--disable-infobars",
                    "--disable-popup-blocking",
                    "--disable-extensions",
                    "enable-automation");

                _firefoxOptions.AddAdditionalCapability("useAutomationExtension", false);
                return _firefoxOptions;
            }
        }

        private InternetExplorerOptions InternetExplorerOptions
        {
            get
            {
                _internetExplorerOptions = new InternetExplorerOptions();
                _internetExplorerOptions.AddAdditionalCapability("useAutomationExtension", false);
                return _internetExplorerOptions;
            }
        }
    }
}
