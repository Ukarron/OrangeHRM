using Allure.NUnit.Attributes;
using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class SystemUsersPage : AbstractPage<SystemUsersPage_Selectors>
    {
        public SystemUsersPage(AppManager p) 
            : base(p, new SystemUsersPage_Selectors()){}

        [AllureStep]
        public void ClickAddButton()
        {
            app.UIInteraction.Click(Selectors.AddButton);
        }
    }

    public class SystemUsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
    }
}
