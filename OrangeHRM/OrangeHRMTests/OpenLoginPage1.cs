using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureSuite("Fail")]
    [Parallelizable]
    public class OpenLoginPage1 : BaseTest
    {
        [Test(Description = "Login and open Reports page")]
        [AllureSeverity(SeverityLevel.Minor)]
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
