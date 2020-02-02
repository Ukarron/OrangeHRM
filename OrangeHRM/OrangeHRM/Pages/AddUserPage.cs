using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.Pages.Components;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class AddUserPage : MainPage<AddUserPage_Selectors>
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
        public AddUserPage EnterUsername(string username)
        {
            app.UIInteraction.EnterText(Selectors.UsernameField, username);
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
            app.UIInteraction.EnterText(Selectors.PasswordField, password);
            return this;
        }

        [AllureStep]
        public AddUserPage SubmitPassword(string password)
        {
            app.UIInteraction.EnterText(Selectors.ConfirmPasswordField, password);
            return this;
        }

        [AllureStep]
        public AddUserPage ClickSave()
        {
            app.UIInteraction.Click(Selectors.SaveButton);
            return this;
        }

        [AllureStep]
        public AddUserPage ClickCancel()
        {
            app.UIInteraction.Click(Selectors.CancelButton);
            return this;
        }

        private DropDown UserRoleDropDown => new DropDown(this.app, Selectors.UserRoleDropDown);
        private DropDown StatusDropDown => new DropDown(this.app, Selectors.StatusDropDown);
    }

    public class AddUserPage_Selectors : MainPage_Selectors
    {
        public readonly By UserRoleDropDown = By.Id("systemUser_userType");
        public readonly By EmployeeNameField = By.Id("systemUser_employeeName_empName");
        public readonly By UsernameField = By.Id("systemUser_userName");
        public readonly By StatusDropDown = By.Id("systemUser_status");
        public readonly By PasswordField = By.Id("systemUser_password");
        public readonly By ConfirmPasswordField = By.Id("systemUser_confirmPassword");
        public readonly By SaveButton = By.Id("btnSave");
        public readonly By CancelButton = By.Id("btnCancel");
    }

    public enum UserRole
    {
        Admin,
        ESS
    }

    public enum UserStatus
    {
        Enabled,
        Disabled
    }
}
