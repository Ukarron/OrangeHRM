using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;

namespace OrangeHRM.Pages
{
    public class AddEmployeePage : AbstractPage<AddEmployeePage_Selectors>
    {
        public AddEmployeePage(AppManager p)
            : base(p, new AddEmployeePage_Selectors()) {}
    }

    public class AddEmployeePage_Selectors
    {
        public readonly By FirstNameField = By.Id("firstName");
        public readonly By MiddleNameField = By.Id("middleName");
        public readonly By LastNameField = By.Id("lastName");
        public readonly By EmployeeIdField = By.Id("employeeId");
        public readonly By PhotoButton = By.Id("photofile");
        public readonly By ChkLoginCheckbox = By.Id("chkLogin");
        public readonly By SaveButton = By.Id("btnSave");
    }
}
