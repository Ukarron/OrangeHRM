using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OrangeHRM
{
    public class UIInteraction
    {
        private IWebDriver _driver;
        private Actions _actions;
        private Waiters _waiter;

        public UIInteraction(IWebDriver driver)
        {
            _driver = driver;
            _waiter = new Waiters(_driver);
        }

        public void Click(By element)
        {
            _waiter.WaitForVisibleDisplayedClickable(element);

            _driver.FindElement(element).Click();
        }

        public void EnterText(By element, string text, bool needToclear = false)
        {
            _waiter.WaitForElementIsVisible(element);

            var el = _driver.FindElement(element);
            if (needToclear)
                el.Clear();
            el.SendKeys(text);
        }

        public string GetText(By element)
        {
            _waiter.WaitForElementIsVisible(element);
            
            return _driver.FindElement(element).Text;
        }

        public void MouseOver(By element)
        {
            _waiter.WaitForElementIsVisible(element);
            Actions.MoveToElement(_driver.FindElement(element)).Perform();
        }

        public Actions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new Actions(_driver);
                }
                return _actions;
            }
        }
    }
}
