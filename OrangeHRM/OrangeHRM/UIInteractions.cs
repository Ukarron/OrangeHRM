using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM
{
    public class UIInteraction
    {
        private const int DEFAULT_WAIT_TIME = 20;

        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;
        private Actions _actions;

        public UIInteraction(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Click(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            _driver.FindElement(element).Click();
        }

        public void EnterText(By element, string text, bool needToclear = false)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            var el = _driver.FindElement(element);
            if (needToclear)
                el.Clear();
            el.SendKeys(text);
        }

        public string GetText(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));

            var parent = _driver.FindElement(element);
            var child = _driver.FindElement(element);
            return parent.Text.Replace(child.Text, "").Trim();
        }

        public void MouseOver(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            Actions.MoveToElement(_driver.FindElement(element)).Perform();
        }

        public WebDriverWait Wait
        {
            get
            {
                if (_webDriverWait == null)
                {
                    _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(DEFAULT_WAIT_TIME));
                }
                return _webDriverWait;
            }
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
