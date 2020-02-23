﻿using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
        public void AddUser(UserRole role, string employeeName, string username, UserStatus status, string password)
        {
            ClickAddButton();

            AddUserPage
                .Select(role)
                .EnterEmployeeName(employeeName)
                .Select(employeeName)
                .EnterUsername(username)
                .Select(status)
                .EnterPassword(password)
                .SubmitPassword(password)
                .ClickSave();
            WaitForSuccessfullySavedMessage();
        }

        private void WaitForSuccessfullySavedMessage()
        {
            app.UIInteraction.Wait.Until(ExpectedConditions.ElementIsVisible(Selectors.SuccessfullySavedMessage));
        }

        public string GetMessage()
        {
            var message = app.UIInteraction.GetText(Selectors.SuccessfullySavedMessage).Trim();
            return message;
        }

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this.app);
    }

    public class SystemUsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
        public readonly By SuccessfullySavedMessage = By.CssSelector(".message.success.fadable");
    }
}