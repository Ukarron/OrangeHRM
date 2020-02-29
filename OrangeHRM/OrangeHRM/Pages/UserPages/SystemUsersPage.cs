using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.DTO;
using OrangeHRM.FrameworkComponents;

namespace OrangeHRM.Pages.UserPages
{
    public class SystemUsersPage : AbstractPage<SystemUsersPage_Selectors>
    {
        private AddUserPage _addUserPage;

        public SystemUsersPage(AppManager p) 
            : base(p, new SystemUsersPage_Selectors()){}

        [AllureStep]
        public void ClickAddButton()
        {
            appManager.UIInteraction.Click(Selectors.AddButton);
        }

        [AllureStep]
        public void AddUser(UserDTO userDTO)
        {
            AddUserPage
                .Select(userDTO.UserRole)
                .EnterEmployeeName(userDTO.EmployeeName)
                .Select(userDTO.EmployeeName)
                .EnterUsername(userDTO.Username)
                .Select(userDTO.Status)
                .EnterPassword(userDTO.Password)
                .SubmitPassword(userDTO.Password)
                .WaitForHelpText();
            AddUserPage.ClickSave();
            WaitForSuccessfullySavedMessage();
        }

        private void WaitForSuccessfullySavedMessage()
        {
            appManager.Waiter.WaitForElementIsVisible(Selectors.SuccessfullySavedMessage);
        }

        public string GetMessage()
        {
            var message = appManager.UIInteraction.GetText(Selectors.SuccessfullySavedMessage).Trim();
            return message;
        }

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this.appManager);
    }

    public class SystemUsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
        public readonly By SuccessfullySavedMessage = By.CssSelector(".message.success.fadable");

        public By GetUsername(string username) => By.XPath($"//table[@id='resultTable']//a[text()='{username}']");
    }
}
