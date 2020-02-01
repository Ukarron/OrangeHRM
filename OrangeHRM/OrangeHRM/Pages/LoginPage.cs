using Allure.NUnit.Attributes;
using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class LoginPage : AbstractPage<LoginPage_Selectors>
    {
        public LoginPage(AppManager p) 
            : base(p, new LoginPage_Selectors()){}

        public void EnterUserName(string username)
        {
            app.UIInteraction.EnterText(Selectors.UsernameField, username);
        }

        public void EnterPassword(string password)
        {
            app.UIInteraction.EnterText(Selectors.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            app.UIInteraction.Click(Selectors.LoginButton);
        }

        [AllureStep]
        public void Login(string username, string password, string url = null)
        {
            if (url == null)
            {
                app.UrlManager.OpenUrl(RunConfiguration.Url);
            }
            else
            {
                app.UrlManager.OpenUrl(url);
            }   

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
