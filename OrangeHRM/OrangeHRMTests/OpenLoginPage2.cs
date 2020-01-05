using NUnit.Framework;
using OrangeHRM.Pages;

namespace OrangeHRMTests
{
    [TestFixture]
    [Parallelizable]
    public class OpenLoginPage2 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest2()
        {
            OpenBrowserAndLogin();

            MainPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "Job", "Job Titles");
        }
    }
}
