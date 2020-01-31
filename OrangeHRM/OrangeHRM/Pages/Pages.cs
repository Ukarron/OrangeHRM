using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class Pages
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private DashboardPage _dashboardPage;
        private AddUserPage _addUserPage;
        private UsersPage _usersPage;
        private UIInteraction _uiInteraction;
        private UrlManager _urlManager;

        public Pages(IWebDriver driver)
        {
            _driver = driver;
        }

        public UrlManager UrlManager => _urlManager = new UrlManager(_driver);
        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(_driver);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public DashboardPage DashboardPage => _dashboardPage = new DashboardPage(this);
        public UsersPage UsersPage => _usersPage = new UsersPage(this);
        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this);
    }
}
