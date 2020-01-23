﻿using Allure.Commons;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OrangeHRM.Pages;
using OrangeHRM.Tools;
using System.IO;

namespace OrangeHRMTests
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        private Pages _pages;
        private Browser _browser = new Browser();

        protected Pages Page => _pages ?? (_pages = new Pages(_browser.Driver));

        [OneTimeSetUp]
        public void OneTimeSetUpTests()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [TearDown]
        public void TearDownTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Screenshot screen = ((ITakesScreenshot)_browser.Driver).GetScreenshot();
                var path = Path.Combine(TestContext.CurrentContext.WorkDirectory);
                screen.SaveAsFile(Path.Combine(TestContext.CurrentContext.WorkDirectory, "Image.png"), ScreenshotImageFormat.Png);

                AllureLifecycle.Instance.AddAttachment(Path.Combine(TestContext.CurrentContext.WorkDirectory, "Image.png"));
            }

            _browser.Close();
        }
    }
}
