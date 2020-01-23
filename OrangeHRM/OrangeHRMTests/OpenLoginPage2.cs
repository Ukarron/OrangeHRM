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
    public class OpenLoginPage2 : BaseTest
    {
        [Test(Description = "Login and open Job Time page")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureTag("Regression")]
        [AllureFeature("Menu")]
        public void OpenLoginPageTest2()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("Time");
        }
    }
}
