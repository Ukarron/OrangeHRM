using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class Pages
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private MainPage _mainPage;
        private UIInteraction _uiInteraction;
        private UrlManager _urlManager;

        public Pages(IWebDriver driver)
        {
            _driver = driver;
        }

        //public void OpenUrl(string url)
        //{
        //    _driver.Navigate().GoToUrl(url);
        //}

        public UrlManager UrlManager => _urlManager = new UrlManager(_driver);
        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(_driver);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public MainPage MainPage => _mainPage = new MainPage(this);
    }
}
