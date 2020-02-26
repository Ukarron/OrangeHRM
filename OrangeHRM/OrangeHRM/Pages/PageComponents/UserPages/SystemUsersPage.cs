using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.FrameworkComponents;
using OrangeHRM.Models;

namespace OrangeHRM.Pages.PageComponents.UserPages
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
        public void AddUser(UserModel userModel)
        {
            ClickAddButton();

            AddUserPage
                .Select(userModel.UserRole)
                .EnterEmployeeName(userModel.EmployeeName)
                .Select(userModel.EmployeeName)
                .EnterUsername(userModel.Username)
                .Select(userModel.Status)
                .EnterPassword(userModel.Password)
                .SubmitPassword(userModel.Password);
            appManager.Waiter.JustWait(500);
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
