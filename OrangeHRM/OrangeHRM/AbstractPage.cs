using OpenQA.Selenium;

namespace OrangeHRM
{
    public abstract class AbstractPage
    {
        private IWebDriver _driver;
        private Helpers _helpers;

        public AbstractPage()
        {
            _helpers = new Helpers();
        }
    }
}
