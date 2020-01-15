﻿using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class LoginPage : AbstractPage<LoginPage_Selectors>
    {
        public LoginPage(Pages p) 
            : base(p, new LoginPage_Selectors()){}

        public void EnterUserName(string username)
        {
            pages.EnterText(Selectors.UsernameField, username);
        }

        public void EnterPassword(string password)
        {
            pages.EnterText(Selectors.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            pages.Click(Selectors.LoginButton);
        }

        public void Login(string username, string password)
        {
            pages.OpenUrl(RunConfiguration.Url);
            EnterUserName(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }

    public class LoginPage_Selectors
    {
        public readonly By UsernameField = By.Id("txtUsername");
        public readonly By PasswordField = By.Id("txtPassword");
        public readonly By LoginButton = By.Name("Submit");
    }
}
