using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public class OpenLoginPage : BaseTest
    {
        [Test]
        public void OpenLoginPageTest()
        {
            OpenBrowserAndLogin();

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;
            Assert.AreEqual(expectedWelcomeText, MainPage.PersonalMenu.GetWelcomeText());
        }
    }
}
