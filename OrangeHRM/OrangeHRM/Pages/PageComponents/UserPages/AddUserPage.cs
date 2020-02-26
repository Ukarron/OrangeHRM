using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;
using OrangeHRM.Models;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages.PageComponents.UserPages
{
    public class AddUserPage : AddPage<AddUserPage_Selectors>
    {
        public AddUserPage(AppManager p) 
            : base(p, new AddUserPage_Selectors()){}

        [AllureStep]
        public AddUserPage Select(UserRole userRole)
        {
            UserRoleDropDown.SelectByText(userRole.GetEnumDescription());
            return this;
        }

        [AllureStep]
        public AddUserPage EnterEmployeeName(string employeeName)
        {
            appManager.UIInteraction.EnterText(Selectors.EmployeeNameField, employeeName);
            return this;
        }

        [AllureStep]
        public AddUserPage Select(string employee)
        {
            appManager.UIInteraction.Click(Selectors.EmployeeName);
            return this;
        }

        [AllureStep]
        public AddUserPage EnterUsername(string username)
        {
            appManager.UIInteraction.EnterText(Selectors.UsernameField, username);
            return this;
        }

        [AllureStep]
        public AddUserPage Select(UserStatus status)
        {
            StatusDropDown.SelectByText(status.GetEnumDescription());
            return this;
        }

        [AllureStep]
        public AddUserPage EnterPassword(string password)
        {
            appManager.UIInteraction.EnterText(Selectors.PasswordField, password);
            return this;
        }

        [AllureStep]
        public AddUserPage SubmitPassword(string password)
        {
            appManager.UIInteraction.EnterText(Selectors.ConfirmPasswordField, password);
            return this;
        }

        [AllureStep]
        public AddUserPage ClickCancel()
        {
            appManager.UIInteraction.Click(Selectors.CancelButton);
            return this;
        }

        private DropDown UserRoleDropDown => new DropDown(this.appManager, Selectors.UserRoleDropDown);
        private DropDown StatusDropDown => new DropDown(this.appManager, Selectors.StatusDropDown);
    }

    public class AddUserPage_Selectors : AddPage_Selectors
    {
        public readonly By UserRoleDropDown = By.Id("systemUser_userType");
        public readonly By EmployeeNameField = By.Id("systemUser_employeeName_empName");
        public readonly By EmployeeName = By.XPath("//*[@class='ac_results']//li");
        public readonly By UsernameField = By.Id("systemUser_userName");
        public readonly By StatusDropDown = By.Id("systemUser_status");
        public readonly By PasswordField = By.Id("systemUser_password");
        public readonly By ConfirmPasswordField = By.Id("systemUser_confirmPassword");
        public readonly By CancelButton = By.Id("btnCancel");
    }
}
