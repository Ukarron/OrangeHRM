﻿using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    public class OpenLoginPage : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void OpenLoginPageTest()
        {
            OpenBrowserAndLogin();

            var expectedWelcomeText = "Welcome " + RunConfiguration.Username;
            Assert.AreEqual(expectedWelcomeText, MainPage.PersonalMenu.GetWelcomeText());

            //MainPage.Menu.MouseOverItem(FirstLevelMenu.Leave);
            MainPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "Job", "Job Titles");
        }
    }
}
