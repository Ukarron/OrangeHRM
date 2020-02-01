using Allure.NUnit.Attributes;
using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class SystemUsersPage : AbstractPage<SystemUsersPage_Selectors>
    {
        private AddUserPage _addUserPage;

        public SystemUsersPage(AppManager p) 
            : base(p, new SystemUsersPage_Selectors()){}

        [AllureStep]
        public void ClickAddButton()
        {
            app.UIInteraction.Click(Selectors.AddButton);
        }

        [AllureStep]
        public void AddUser(UserRole role, string username, UserStatus status, string password)
        {
            ClickAddButton();

            AddUserPage
                .Select(role)
                .EnterUsername(username)
                .Select(status)
                .EnterPassword(password)
                .SubmitPassword(password)
                .ClickSave();
        }

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this.app);
    }

    public class SystemUsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
    }
}
