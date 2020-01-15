using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class Pages
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private MainPage _mainPage;
        private UIInteraction _uiInteraction;

        public Pages(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(_driver);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public MainPage MainPage => _mainPage = new MainPage(this);
    }
}
