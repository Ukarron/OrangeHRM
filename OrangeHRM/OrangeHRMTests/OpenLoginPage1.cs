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
    public class OpenLoginPage1 : BaseTest
    {
        [Test(Description = "Login and open Reports page")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureTag("Regression")]
        [AllureFeature("Menu")]
        public void OpenLoginPageTest1()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Reports");
            Assert.True(false);
        }
    }
}
