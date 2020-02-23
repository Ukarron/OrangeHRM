using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM
{
    public sealed class Waiters
    {
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;
        private const int DEFAULT_WAIT_TIME = 20;

        public Waiters(IWebDriver driver)
        {
            this._driver = driver;
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(DEFAULT_WAIT_TIME));
        }

        public Waiters(IWebDriver driver, int waitTime)
        {
            this._driver = driver;
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(waitTime));
        }

        public void WaitForElementIsVisible(By element)
        {
            _webDriverWait.Until(ExpectedConditions.ElementIsVisible(element));
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
    }
}
