using OrangeHRM.Pages.PageComponents;

namespace OrangeHRM.Pages
{
    public class DashboardPage : MainPage<DashboardPage_Selectors>
    {
        public DashboardPage(AppManager p) 
            : base(p, new DashboardPage_Selectors()) {}
    }

    public class DashboardPage_Selectors : MainPage_Selectors
    {
    }
}
