using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OrangeHRM.Pages;
using OrangeHRM.Tools;
using System;
using System.IO;

namespace OrangeHRMTests
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        private Pages _pages;
        private Browser _browser = new Browser();

        protected Pages Page => _pages ?? (_pages = new Pages(_browser.Driver));

        [OneTimeTearDown]
        public void OneTimeTearDownTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Screenshot image = ((ITakesScreenshot)_browser.Driver).GetScreenshot();
                image.SaveAsFile(@"C:\\allure\allure-2.7.0\bin\allure-results\Screenshot1.png", ScreenshotImageFormat.Png);

                AllureLifecycle.Instance.AddAttachment(@"C:\\allure\allure-2.7.0\bin\allure-results\Screenshot1.png", "Screenshot1.png");
            }

            _browser.Close();
        }
    }
}
