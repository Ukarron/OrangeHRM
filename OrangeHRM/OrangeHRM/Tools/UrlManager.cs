﻿using OpenQA.Selenium;

namespace OrangeHRM.Tools
{
    public sealed class UrlManager
    {
        private IWebDriver _driver;

        public UrlManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static string UsersPage()
        {
            return "https://opensource-demo.orangehrmlive.com/index.php/admin/viewSystemUsers";
        }
    }
}
