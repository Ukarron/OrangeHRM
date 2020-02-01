using Allure.NUnit.Attributes;
using OpenQA.Selenium;

namespace OrangeHRM.Pages
{
    public class UsersPage : AbstractPage<UsersPage_Selectors>
    {
        public UsersPage(AppManager p) 
            : base(p, new UsersPage_Selectors()){}

        [AllureStep]
        public void ClickAddButton()
        {
            app.UIInteraction.Click(Selectors.AddButton);
        }
    }

    public class UsersPage_Selectors
    {
        public readonly By AddButton = By.Id("btnAdd");
    }
}
