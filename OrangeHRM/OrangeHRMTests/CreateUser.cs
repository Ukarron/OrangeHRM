using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Tools;

namespace OrangeHRMTests
{
    [TestFixture]
    [AllureSuite("Pass")]
    [Parallelizable]
    public class CreateUser : BaseTest
    {
        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Minor)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateUserTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "User Management", "Users");

            Page.UsersPage.ClickAddButton();
        }
    }
}
