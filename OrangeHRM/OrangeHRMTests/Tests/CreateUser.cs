using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;
using System.Threading;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class CreateUser : BaseTest
    {
        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateUserTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "User Management", "Users");

            Page.UsersPage.ClickAddButton();

            Page.AddUserPage.Select(UserRole.Admin);
            Page.AddUserPage.Select(UserStatus.Disabled);

            Thread.Sleep(3000);
        }
    }
}
