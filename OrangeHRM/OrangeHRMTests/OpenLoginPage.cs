using NUnit.Framework;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    public class Test1
    {
        Browser browser = new Browser();

        [Test]
        public void OpenLoginPageTest()
        {
            browser.OpenUrl();

            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDownTest()
        {
            Browser.Close();
        }
    }
}
