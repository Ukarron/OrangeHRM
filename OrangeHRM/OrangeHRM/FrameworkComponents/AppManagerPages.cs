using OrangeHRM.Pages;
using OrangeHRM.Pages.EmployeePages;
using OrangeHRM.Pages.UserPages;

namespace OrangeHRM.FrameworkComponents
{
    public partial class AppManager
    {
        private AddUserPage _addUserPage;
        private DashboardPage _dashboardPage;
        private AddEmployeePage _addEmployeePage;
        private LoginPage _loginPage;
        private SystemUsersPage _systemUsersPage;

        public AddUserPage AddUserPage => _addUserPage = new AddUserPage(this);
        public DashboardPage DashboardPage => _dashboardPage = new DashboardPage(this);
        public AddEmployeePage AddEmployeePage => _addEmployeePage = new AddEmployeePage(this);
        public LoginPage LoginPage => _loginPage = new LoginPage(this);
        public SystemUsersPage SystemUsersPage => _systemUsersPage = new SystemUsersPage(this);
    }
}
