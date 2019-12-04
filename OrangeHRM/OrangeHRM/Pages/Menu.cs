using OpenQA.Selenium;
using OrangeHRM.Tools;
using System.ComponentModel;

namespace OrangeHRM.Pages
{
    public class Menu : AbstractPage<Menu_Selectors>
    {
        public Menu() 
            : base(new Menu_Selectors()){}

        public void SelectItem(MenuItem item)
        {
            Helpers.Click(Selectors.MenuItem(item));
        }
    }

    public class Menu_Selectors
    {
        public By MenuItem(MenuItem item) => By.XPath($"//*[@class='firstLevelMenu']/b[text()='{item.GetEnumDescription()}']");
    }

    public enum MenuItem
    {
        [Description("Admin")] Admin,
        [Description("PIM")] PIM,
        [Description("Leave")] Leave,
        [Description("Time")] Time,
        [Description("Recruitment")] Recruitment,
        [Description("Performance")] Performance,
        [Description("Dashboard")] Dashboard,
        [Description("Directory")] Directory,
        [Description("Maintenance")] Maintenance,
    }
}
