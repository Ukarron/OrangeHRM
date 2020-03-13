using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace OrangeHRM
{
    public class UIInteraction
    {
        private IWebDriver _driver;
        private IJavaScriptExecutor _executor;
        private Actions _actions;
        private Waiters _waiter;

        public UIInteraction(IWebDriver driver)
        {
            _driver = driver;
            _waiter = new Waiters(_driver);
        }

        public void JSClick(By element)
        {
            _waiter.WaitForVisibleDisplayedClickable(element);

            JavaScriptExecutor.ExecuteScript("arguments[0].click();", element);
        }

        public void Click(By element)
        {
            _waiter.WaitForVisibleDisplayedClickable(element);

            _driver.FindElement(element).Click();
        }

        public void EnterText(By element, string text, bool needToClear = false)
        {
            _waiter.WaitForElementIsVisible(element);

            var el = _driver.FindElement(element);
            if (needToClear)
                el.Clear();
            el.SendKeys(text);
        }

        public string GetText(By element)
        {
            _waiter.WaitForElementIsVisible(element);
            
            return _driver.FindElement(element).Text;
        }

        public string GetValueText(By element, string attribute)
        {
            _waiter.WaitForElementIsVisible(element);

            return _driver.FindElement(element).GetAttribute(attribute);
        }

        public void MouseOver(By element)
        {
            _waiter.WaitForElementIsVisible(element);
            Actions.MoveToElement(_driver.FindElement(element)).Perform();
        }

        public void UploadFile(By element, string filePath)
        {
            var input = _driver.FindElement(element);
            _waiter.WaitForElementExists(element);
            input.SendKeys(filePath);
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

        public IJavaScriptExecutor JavaScriptExecutor
        {
            get
            {
                if (_executor == null)
                {
                    _executor = (IJavaScriptExecutor)_driver;
                }
                return _executor;
            }
        }
    }
}
