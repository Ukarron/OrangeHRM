using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.DTO;
using OrangeHRM.Tools;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class CreateUser : BaseTest
    {
        private UserDTO _userDTO = new UserDTO(UserRole.Admin, UserStatus.Enabled, "Fiona Grace");

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateUserTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            AppManager.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "User Management", "Users");

            AppManager.SystemUsersPage.ClickAddButton();
            AppManager.SystemUsersPage.AddUser(_userDTO);

            var expectedUsername = _userDTO.Username;
            var actualUsername = AppManager.UIInteraction.GetText(AppManager.SystemUsersPage.Selectors.GetUsername(_userDTO.Username));

            Assert.AreEqual(expectedUsername, actualUsername, $"FAIL: {expectedUsername} was not found!");
        }
    }
}
