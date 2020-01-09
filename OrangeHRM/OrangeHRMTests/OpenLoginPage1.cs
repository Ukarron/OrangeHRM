﻿using NUnit.Framework;
using OrangeHRM.Pages;

namespace OrangeHRMTests
{
    [TestFixture]
    [Parallelizable]
    public class OpenLoginPage1 : BaseTest
    {
        [Test]
        public void OpenLoginPageTest1()
        {
            OpenBrowserAndLogin();

            MainPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "Job", "Job Titles");
        }
    }
}
