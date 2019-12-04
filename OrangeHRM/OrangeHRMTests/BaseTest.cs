using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private Browser _browser;
        private LoginPage _loginPage;
        private MainPage _mainPage;

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            Browser.Close();
        }

        public void OpenBrowserAndLogin()
        {
            Browser.OpenBaseUrl();
            LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);
        }

        protected Browser Browser
        {
            get
            {
                return _browser = new Browser();
            }
        }

        protected LoginPage LoginPage => _loginPage = new LoginPage();
        protected MainPage MainPage => _mainPage = new MainPage();
    }
}
