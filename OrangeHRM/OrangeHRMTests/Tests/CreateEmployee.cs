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
    public class CreateEmployee : BaseTest
    {
        private string _filePath = @"C:\\Users\1\Pictures\Снимок1.PNG";
        private UserDTO _userDTO = new UserDTO();

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateEmployeeTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            AppManager.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Add Employee");

            AppManager.AddEmployeePage.AddEmployee(Faker.Name.First(), Faker.Name.Last(), filePath: _filePath, create: true, userDTO: _userDTO);
        }
    }
}
