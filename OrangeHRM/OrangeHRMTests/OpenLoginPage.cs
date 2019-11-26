using NUnit.Framework;
using System.Threading;

namespace OrangeHRMTests
{
    [TestFixture]
    [Chrome, Firefox]
    public class Test1
    {
        Browser browser = new Browser();

        [Test]
        public void OpenLoginPageTest()
        {
            browser.OpenUrl();

            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownTest()
        {
            Browser.Close();
        }
    }
}
