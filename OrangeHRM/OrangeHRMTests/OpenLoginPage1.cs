using NUnit.Allure.Core;
using NUnit.Framework;
using OrangeHRM.Tools;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    public class OpenLoginPage1 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest1()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Reports");
            Assert.True(false);
            Thread.Sleep(5000);
        }
    }
}
