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
        private SystemUsersPage _systemUsersPage;

        private UrlManager _urlManager;
        private UIInteraction _uiInteraction;
        private Waiters _waiter;

        public AppManager(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebDriver Driver => _driver;

        public UrlManager UrlManager => _urlManager = new UrlManager(Driver);
        public UIInteraction UIInteraction => _uiInteraction = new UIInteraction(Driver);
        public Waiters Waiter => _waiter = new Waiters(Driver);

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this);
        public DashboardPage DashboardPage => _dashboardPage = new DashboardPage(this);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);        
        public SystemUsersPage SystemUsersPage => _systemUsersPage = new SystemUsersPage(this);        
    }
}
