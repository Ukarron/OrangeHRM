using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OrangeHRM;
using OrangeHRM.FrameworkComponents;
using System.IO;

namespace OrangeHRMTests
{
    [SetUpFixture]
    public abstract class BaseTest : AllureReport
    {
        private AppManager _appManager;
        private Browser _browser = new Browser();

        protected AppManager AppManager => _appManager ?? (_appManager = new AppManager(_browser.Driver));

        [OneTimeSetUp]
        public void OneTimeSetUpTests()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [TearDown]
        public void TearDownTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Screenshot screen = ((ITakesScreenshot)_browser.Driver).GetScreenshot();
                var path = Path.Combine(TestContext.CurrentContext.WorkDirectory);
                screen.SaveAsFile(Path.Combine(TestContext.CurrentContext.WorkDirectory, "Image.png"), ScreenshotImageFormat.Png);

                AllureLifecycle.Instance.AddAttachment(Path.Combine(TestContext.CurrentContext.WorkDirectory, "Image.png"));
            }

            _browser.CloseBrowser();
        }
    }
}
