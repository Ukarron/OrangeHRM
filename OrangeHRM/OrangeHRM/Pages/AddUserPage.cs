using OpenQA.Selenium;
using OrangeHRM.Pages.Components;
using OrangeHRM.Tools;

namespace OrangeHRM.Pages
{
    public class AddUserPage : MainPage<AddUserPage_Selectors>
    {
        public AddUserPage(AppManager p) 
            : base(p, new AddUserPage_Selectors()){}

        public void Select(UserRole userRole)
        {
            UserRoleDropDown.SelectByText(userRole.GetEnumDescription());
        }

        public void Select(UserStatus status)
        {
            StatusDropDown.SelectByText(status.GetEnumDescription());
        }

        private DropDownHandler UserRoleDropDown => new DropDownHandler(app.Driver, Selectors.userRoleDropDown);
        private DropDownHandler StatusDropDown => new DropDownHandler(app.Driver, Selectors.statusDropDown);
    }

    public class AddUserPage_Selectors : MainPage_Selectors
    {
        public By userRoleDropDown = By.Id("systemUser_userType");
        public By statusDropDown = By.Id("systemUser_status");
    }

    public enum UserRole
    {
        Admin,
        ESS
    }

    public enum UserStatus
    {
        Enabled,
        Disabled
    }
}
