using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using CodeBits;
using NUnit.Framework;
using OrangeHRM.Pages;
using OrangeHRM.Tools;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class CreateUser : BaseTest
    {
        private string _username = Faker.Internet.UserName();
        private string _password = PasswordGenerator.Generate(12, PasswordCharacters.All);        
        private string _employeeName = "Fiona Grace";

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateUserTest()
        {
            Page.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            Page.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("Admin", "User Management", "Users");

            Page.SystemUsersPage.AddUser(UserRole.Admin, _employeeName, _username, UserStatus.Enabled, _password);

            var expectedMessage = "Successfully Saved";

            Assert.AreEqual(expectedMessage, Page.SystemUsersPage.GetMessage());
        }
    }
}
