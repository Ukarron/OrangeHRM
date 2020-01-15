using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public abstract class BaseTest
    {
        private Pages _pages;
        private Browser _browser = new Browser();

        protected Pages Page => _pages ?? (_pages = new Pages(_browser.Driver));

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            _browser.Close();
        }
    }
}
