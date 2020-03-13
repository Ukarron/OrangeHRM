using Allure.Commons.Model;
using Allure.NUnit.Attributes;
using NUnit.Framework;
using OrangeHRM.DTO;
using OrangeHRM.Tools;
using System.IO;
using System.Reflection;

namespace OrangeHRMTests.Tests
{
    [TestFixture]
    [AllureSuite("GUI")]
    [Parallelizable]
    public class CreateEmployee : BaseTest
    {
        private static string _pathToDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        private static string _iconPath = Path.Combine(_pathToDirectory, "TestImage.jpg");
        private string _correctPath = _iconPath.Remove(0, 6);
        private UserDTO _userDTO = new UserDTO();

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateEmployeeTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            AppManager.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Add Employee");

            AppManager.AddEmployeePage.AddEmployee(Faker.Name.First(), Faker.Name.Last(), filePath: _correctPath, create: true, userDTO: _userDTO);
        }
    }
}
