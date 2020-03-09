using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.DTO;
using OrangeHRM.FrameworkComponents;
using OrangeHRM.Pages.PageComponents;
using OrangeHRM.Tools;
using System;

namespace OrangeHRM.Pages.EmployeePages
{
    public class AddEmployeePage : AddPage<AddEmployeePage_Selectors>
    {
        public string EmployeeId { private set; get; }

        public AddEmployeePage(AppManager p)
            : base(p, new AddEmployeePage_Selectors()) { }

        [AllureStep]
        public string AddEmployee(string firstName, string lastName, string middleName = null, string id = null, string filePath = null, bool create = false,
            UserDTO userDTO = null)
        {
            EnterFirstName(firstName)
                .EnterLastName(lastName)
                .EnterMiddleName(middleName)
                .SetEmployeeId(id)
                .UploadPhotograph(filePath)
                .CreateLoginDetails(create, userDTO);
            EmployeeId = GetEmployeeId();

            ClickSave();

            return EmployeeId;
        }

        [AllureStep]
        public AddEmployeePage EnterFirstName(string firstName)
        {
            appManager.UIInteraction.EnterText(Selectors.FirstNameField, firstName);
            return this;
        }

        [AllureStep]
        public AddEmployeePage EnterLastName(string lastName)
        {
            appManager.UIInteraction.EnterText(Selectors.LastNameField, lastName);
            return this;
        }

        [AllureStep]
        public AddEmployeePage EnterMiddleName(string middleName = null)
        {
            if (!String.IsNullOrEmpty(middleName))
                appManager.UIInteraction.EnterText(Selectors.MiddleNameField, middleName);
            return this;
        }

        [AllureStep]
        public AddEmployeePage SetEmployeeId(string id = null)
        {
            if (!String.IsNullOrEmpty(id))
                appManager.UIInteraction.EnterText(Selectors.EmployeeIdField, id);
            return this;
        }

        [AllureStep]
        public string GetEmployeeId(string attribute = "value")
        {
            return appManager.UIInteraction.GetValueText(Selectors.EmployeeIdField, attribute);
        }

        [AllureStep]
        public AddEmployeePage UploadPhotograph(string filePath = null)
        {
            if (!String.IsNullOrEmpty(filePath))
                appManager.UIInteraction.UploadFile(Selectors.PhotoButton, filePath);
            return this;
        }

        [AllureStep]
        public AddEmployeePage CreateLoginDetails(bool create, UserDTO userDTO)
        {
            if (create)
                ClickCreateLoginDetailsCheckbox()
                .EnterUsername(userDTO.Username)
                .EnterPassword(userDTO.Password)
                .ConfirmPassword(userDTO.Password)
                .Select(userDTO.Status);
            return this;
        }

        [AllureStep]
        private AddEmployeePage ClickCreateLoginDetailsCheckbox()
        {
            appManager.UIInteraction.Click(Selectors.CreateLoginDetailsCheckbox);
            return this;
        }

        [AllureStep]
        private AddEmployeePage EnterUsername(string username)
        {
            appManager.UIInteraction.EnterText(Selectors.UserNameField, username);
            return this;
        }

        [AllureStep]
        private AddEmployeePage EnterPassword(string password)
        {
            appManager.UIInteraction.EnterText(Selectors.PasswordField, password);
            return this;
        }

        [AllureStep]
        private AddEmployeePage ConfirmPassword(string password)
        {
            appManager.UIInteraction.EnterText(Selectors.ConfirmPasswordField, password);
            return this;
        }

        [AllureStep]
        private AddEmployeePage Select(UserStatus status)
        {
            StatusDropDown.SelectByText(status.GetEnumDescription());
            return this;
        }

        private DropDown StatusDropDown => new DropDown(this.appManager, Selectors.StatusDropDown);
    }

    public class AddEmployeePage_Selectors : AddPage_Selectors
    {
        public readonly By FirstNameField = By.Id("firstName");
        public readonly By MiddleNameField = By.Id("middleName");
        public readonly By LastNameField = By.Id("lastName");
        public readonly By EmployeeIdField = By.Id("employeeId");
        public readonly By PhotoButton = By.Id("photofile");
        public readonly By CreateLoginDetailsCheckbox = By.Id("chkLogin");

        public readonly By UserNameField = By.Id("user_name");
        public readonly By PasswordField = By.Id("user_password");
        public readonly By ConfirmPasswordField = By.Id("re_password");
        public readonly By StatusDropDown = By.Id("status");
    }
}
