using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureSuite("Pass")]
    [Parallelizable]
    public class OpenLoginPage : BaseTest
    {
        [Test(Description = "Login into the application")]
        [AllureSeverity(SeverityLevel.Critical)]
        [AllureTag("Regression")]
        [AllureFeature("Login")]
        public void OpenLoginPageTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;

            Assert.AreEqual(expectedWelcomeText, Page.DashboardPage.PersonalMenu.GetWelcomeText());
        }
    }
}
