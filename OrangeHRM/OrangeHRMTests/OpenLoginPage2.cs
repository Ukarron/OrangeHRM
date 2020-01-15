using NUnit.Framework;
using System.Threading;

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

            Page.MainPage.Menu.ExpandMenuTreeAndSeectItem("Time");

            Thread.Sleep(10000);
        }
    }
}
