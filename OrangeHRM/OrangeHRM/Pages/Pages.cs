using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM.Pages
{
    public class Pages
    {
        private IWebDriver Driver;
        private WebDriverWait _webDriverWait;
        private Actions _actions;
        private int _defaultWaitTime = 20;

        private LoginPage _loginPage;
        private MainPage _mainPage;

        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public MainPage MainPage => _mainPage = new MainPage(this);

        public Pages(IWebDriver driver)
        {
            Driver = driver;
        }

        public void OpenUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void Click(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            Driver.FindElement(element).Click();
        }

        public void EnterText(By element, string text, bool needToclear = false)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            var el = Driver.FindElement(element);
            if (needToclear)
                el.Clear();
            el.SendKeys(text);
        }

        public string GetText(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            return Driver.FindElement(element).Text;
        }

        public void MouseOver(By element)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(element));
            Actions.MoveToElement(Driver.FindElement(element)).Perform();
        }

        private WebDriverWait Wait
        {
            get
            {
                if (_webDriverWait == null)
                {
                    _webDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(_defaultWaitTime));
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
                    _actions = new Actions(Driver);
                }
                return _actions;
            }
        }
    }
}
