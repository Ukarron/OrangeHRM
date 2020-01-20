using NUnit.Allure.Core;
using NUnit.Framework;
using OrangeHRM.Tools;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureNUnit]
    [Parallelizable]
    public class OpenLoginPage : BaseTest
    {
        [Test]
        public void OpenLoginPageTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;
            Assert.AreEqual(expectedWelcomeText, Page.MainPage.PersonalMenu.GetWelcomeText());

            //MainPage.Menu.MouseOverItem(FirstLevelMenu.Leave);
            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "Job", "Job Titles");

            Thread.Sleep(1000);
        }
    }
}
