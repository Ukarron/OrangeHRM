using OrangeHRM.Pages;

namespace OrangeHRM.FrameworkComponents
{
    public partial class AppManager
    {
        private AddUserPage _addUserPage;
        private DashboardPage _dashboardPage;
        private LoginPage _loginPage;
        private SystemUsersPage _systemUsersPage;

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this);
        public DashboardPage DashboardPage => _dashboardPage = new DashboardPage(this);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public SystemUsersPage SystemUsersPage => _systemUsersPage = new SystemUsersPage(this);
    }
}
