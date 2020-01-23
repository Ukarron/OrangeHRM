using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    public class OpenLoginPage : BaseTest
    {
        [Test(Description = "Login and open Job Titles page")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureTag("Regression")]
        [AllureFeature("Menu")]
        public void OpenLoginPageTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;
            Assert.AreEqual(expectedWelcomeText, Page.MainPage.PersonalMenu.GetWelcomeText());
            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "Job", "Job Titles");
        }
    }
}
