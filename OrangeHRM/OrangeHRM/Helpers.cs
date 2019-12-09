using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OrangeHRMTests;
using System;

namespace OrangeHRM
{
    public class Helpers
    {
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;
        private int _defaultWaitTime = 20;
        private Actions _actions; 

        public Helpers(IWebDriver driver)
        {
            this._driver = driver;
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
            return _driver.FindElement(element).Text;
        }

        public void MouseOver(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            Actions.MoveToElement(Browser.Driver.FindElement(element)).Perform();
        }

        private WebDriverWait Wait
        {
            get
            {
                if (_webDriverWait == null)
                {
                    _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(_defaultWaitTime));
                }
                return _webDriverWait;
            }
        }

        private Actions Actions
        {
            get
            {
                if (_actions == null)
                {
                    _actions = new Actions(Browser.Driver);
                }
                return _actions;
            }
        }
    }
}
