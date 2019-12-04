using NUnit.Framework;
using OrangeHRM;

namespace OrangeHRMTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private Browser _browser;
        private LoginPage _loginPage;

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            Browser.Close();
        }

        public void Login(string username = "Admin", string password = "admin123")
        {
            Browser.OpenBaseUrl();
        }

        protected Browser Browser
        {
            get
            {
                return _browser = new Browser();
            }
        }

        protected LoginPage LoginPage => _loginPage = new LoginPage();
    }
}
