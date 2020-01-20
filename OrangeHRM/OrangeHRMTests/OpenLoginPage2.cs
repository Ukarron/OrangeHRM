using NUnit.Allure.Core;
using NUnit.Framework;
using OrangeHRM.Tools;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    public class OpenLoginPage2 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest2()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("Time");

            Thread.Sleep(10000);
        }
    }
}
