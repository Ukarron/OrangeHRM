using NUnit.Framework;
using OrangeHRM;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private Browser _browser;
        private LoginPage _loginPage;
        private PersonalMenu _personalMenu;

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
        protected PersonalMenu PersonalMenu => _personalMenu = new PersonalMenu();
    }
}
