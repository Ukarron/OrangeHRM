using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.Models;
using OrangeHRM.Tools;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class CreateUser : BaseTest
    {
        private UserModel _userModel = new UserModel("Fiona Grace", UserRole.Admin, UserStatus.Enabled); 

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateUserTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            AppManager.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "User Management", "Users");

            AppManager.SystemUsersPage.AddUser(_userModel);

            var expectedUsername = _userModel.Username;
            var actualUsername = AppManager.UIInteraction.GetText(AppManager.SystemUsersPage.Selectors.GetUsername(_userModel.Username));

            Assert.AreEqual(expectedUsername, actualUsername, $"FAIL: {expectedUsername} was not found!");
        }
    }
}
