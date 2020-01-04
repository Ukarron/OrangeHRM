using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    [Parallelizable]
    public abstract class BaseTest
    {
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

        protected LoginPage LoginPage => _loginPage = new LoginPage();
        protected MainPage MainPage => _mainPage = new MainPage();
    }
}
