using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class OpenLoginPage : BaseTest
    {
        [Test(Description = "Login into the application")]
        [AllureSeverity(SeverityLevel.Critical)]
        [AllureTag("Regression")]
        [AllureFeature("Login")]
        public void OpenLoginPageTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;

            Assert.AreEqual(expectedWelcomeText, AppManager.DashboardPage.PersonalMenu.GetWelcomeText());
        }
    }
}
