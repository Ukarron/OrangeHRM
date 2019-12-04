using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class LoginPage : AbstractPage<LoginPage_Selectors>
    {
        public LoginPage() 
            : base(new LoginPage_Selectors()){}

        public void EnterUserName(string username)
        {
            Helpers.EnterText(Selectors.UsernameField, username);
        }

        public void EnterPassword(string password)
        {
            Helpers.EnterText(Selectors.PasswordField, password);
        }

        public void ClickLoginButton()
        {
            Helpers.Click(Selectors.LoginButton);
        }

        public void Login(string username, string password)
        {
            EnterUserName(username);
            EnterPassword(password);
            ClickLoginButton();
        }
    }

    public class LoginPage_Selectors : AbstractPage_Selectors
    {
        public readonly By UsernameField = By.Id("txtUsername");
        public readonly By PasswordField = By.Id("txtPassword");
        public readonly By LoginButton = By.Name("Submit");
    }
}
