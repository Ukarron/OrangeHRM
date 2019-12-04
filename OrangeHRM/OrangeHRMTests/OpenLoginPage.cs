using NUnit.Framework;
using OrangeHRM;

namespace OrangeHRMTests
{
    [TestFixture]
    public class Test1 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest()
        {
            OpenBrowserAndLogin();

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;
            Assert.AreEqual(expectedWelcomeText, PersonalMenu.GetWelcomeText());
        }
    }
}
