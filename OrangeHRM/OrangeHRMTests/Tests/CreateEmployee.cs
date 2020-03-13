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
        private string _path = @"C:\\Users\1\Pictures\Снимок1.PNG";
        //private static string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        //private string iconPath = Path.Combine(_path, @"OrangeHRMTests\TestFile.jpg");
        private UserDTO _userDTO = new UserDTO();

        [Test(Description = "Create new user")]
        [AllureSeverity(SeverityLevel.Normal)]
        [AllureTag("Regression")]
        [AllureFeature("Users")]
        public void CreateEmployeeTest()
        {
            AppManager.LoginPage.Login(RunConfiguration.Username, RunConfiguration.Password);

            AppManager.DashboardPage.Menu.ExpandMenuTreeAndSeectItem("PIM", "Add Employee");

            AppManager.AddEmployeePage.AddEmployee(Faker.Name.First(), Faker.Name.Last(), filePath: _path, create: true, userDTO: _userDTO);
        }
    }
}
