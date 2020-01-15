using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private Pages _pages;
        private LoginPage _loginPage;
        private MainPage _mainPage;

        protected Pages Pages => _pages ?? (_pages = new Pages(Driver));

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            Close();
        }

        public void OpenBrowserAndLogin()
        {
            OpenBaseUrl();
            LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);
        }

        protected LoginPage LoginPage => _loginPage = new LoginPage(this.Pages);
        protected MainPage MainPage => _mainPage = new MainPage(this.Pages);

        public const string Chrome = "Chrome";
        public const string Firefox = "Firefox";
        public const string InternetExplorer = "InternetExplorer";

        private IWebDriver _driver;
        private static ChromeOptions _chromeOptions;
        private static FirefoxOptions _firefoxOptions;
        private static InternetExplorerOptions _internetExplorerOptions;


        //public IWebDriver Start()
        //{
        //    var browser = RunConfiguration.Browser;

        //    switch (browser)
        //    {
        //        case "Chrome":
        //            _driver = new ChromeDriver(ChromeOptions);
        //            break;

        //        case "Firefox":
        //            _driver = new FirefoxDriver(FirefoxOptions);
        //            break;

        //        case "IE":
        //            _driver = new InternetExplorerDriver(InternetExplorerOptions);
        //            break;

        //        default:
        //            _driver = new ChromeDriver(ChromeOptions);
        //            break;
        //    }
        //    _driver.Manage().Window.Maximize();

        //    return _driver;
        //}

        public void OpenBaseUrl()
        {
            var url = RunConfiguration.Url;

            Driver.Navigate().GoToUrl(url);
        }

        public IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    //_driver = Start();
                    _driver = new ChromeDriver();
                    _driver.Manage().Window.Maximize();
                }
                return _driver;
            }
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

        public void Close()
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
