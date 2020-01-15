using NUnit.Framework;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    [Parallelizable]
    public class OpenLoginPage1 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest1()
        {
            OpenBrowserAndLogin();

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Reports");

            Thread.Sleep(10000);
        }
    }
}
