using OpenQA.Selenium;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class AppManager
    {
        private IWebDriver _driver;

        private AddUserPage _addUserPage;
        private DashboardPage _dashboardPage;
        private LoginPage _loginPage;        
        private SystemUsersPage _usersPage;

        private UrlManager _urlManager;
        private UIInteraction _uiInteraction;                

        public AppManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public UrlManager UrlManager => _urlManager = new UrlManager(Driver);
        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(Driver);

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this);
        public DashboardPage DashboardPage => _dashboardPage = new DashboardPage(this);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);        
        public SystemUsersPage UsersPage => _usersPage = new SystemUsersPage(this);        
    }
}
